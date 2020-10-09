using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Numerics;
using System.Drawing;
using System.Threading;
using BaxLogger;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Timer = System.Timers.Timer;

namespace SpeedTestBackgroundWorker
{
    class Program
    {
        private static Logger logger;

        private static Timer scanTimer;
        private static Timer cleanupTimer;

        private static string PathToFolder = Environment.CurrentDirectory;

        private static string OutputPath = PathToFolder + "/Data/Report.dat";
        private static string CSVPath = PathToFolder + "/Data/Values.csv";
        private static string ExePath = PathToFolder + "/Ookla/speedtest.exe";
        private static string LogPath = PathToFolder + $"/Data/OutputLog_{DateTime.Now.DayOfYear}.txt";
        private static string ExeArgs;

        private static DateTime LastScan;

        private static BigInteger TestCounter;

        private static bool Quit = false;
        private static bool ScanRunning = false;

        static void Main(string[] args)
        {
            TestCounter = 0;

            logger = new Logger(true);

            scanTimer = new Timer { Interval = 3600 * 1000 };
            scanTimer.Elapsed += Timer_Elapsed;

            cleanupTimer = new Timer { Interval = ((3600 * 1000) * 24) * 7};
            cleanupTimer.Elapsed += CleanupTimerOnElapsed;

            //Arguments
            ExeArgs = "--format json-pretty";

            logger.ToggleWindow();

            try
            {
                logger.Log("Starting program...", logger.STATUS_OKAY);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            #if DEBUG
            logger.ToggleWindow();        
            #endif

            //start tray icon thread
            Thread notifyThread = new Thread(
                delegate ()
                {
                    NotifyIcon trayIcon = new NotifyIcon();
                    ContextMenu cm = new ContextMenu();
                    cm.MenuItems.Add("Close Speedtest Background Worker", QuitProgram);
                    cm.MenuItems.Add("Toggle Console", ShowHideConsole);
                    trayIcon.ContextMenu = cm;
                    trayIcon.Text = "Speedtester";
                    trayIcon.Visible = true;
                    trayIcon.BalloonTipIcon = ToolTipIcon.Info;
                    trayIcon.BalloonTipTitle = "Speedtester";
                    trayIcon.BalloonTipText = "Started Speedtester!";
                    trayIcon.Icon = new Icon("icon.ico", new Size(40, 40));
                    Application.Run();
                }
            );
            notifyThread.Start();
            
            //Force scan at start up
            Timer_Elapsed(null, null);
            CleanupTimerOnElapsed(null, null);

            //Start timers
            scanTimer.Start();
            cleanupTimer.Start();

            while (!Quit)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\ncmd://> ");
                Console.ForegroundColor = ConsoleColor.White;

                string[] commands = Console.ReadLine().Split(' ');
                string op = commands[0];
                List<string> opArgs = commands.ToList();
                opArgs.RemoveAt(0);

                switch (op.ToLower())
                {
                    case "status":
                        PrintStatus();
                        break;
                    case "scan":
                        Timer_Elapsed(null, null);
                        break;
                    case "bg":
                    case "background":
                        logger.ToggleWindow();
                        break;
                    case "quit":
                    case "exit":
                        Quit = true;
                        return;
                }
            }
        }


        private static void QuitProgram(object sender, EventArgs e)
        {
            Quit = true;
            Application.Exit();
        }

        private static void ShowHideConsole(object sender, EventArgs e)
        {
            logger.ToggleWindow();
        }

        private static void PrintStatus()
        {
            TimeSpan time = DateTime.Now - LastScan;
            Console.WriteLine($"Time since last scan: {time}");
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if(ScanRunning) return;

            ScanRunning = true;
            LogPath = PathToFolder + $"/Data/OutputLog_{DateTime.Now.DayOfYear}.txt";
            logger = new Logger(false);

            LastScan = DateTime.Now;
            TestCounter++;
            logger.Log($"Started test ({TestCounter})");
            try
            {
                Process process = new Process();
                ProcessStartInfo psi = new ProcessStartInfo(ExePath, ExeArgs)
                {
                    CreateNoWindow = true, 
                    UseShellExecute = false,
                    RedirectStandardOutput = true
                };

                process.StartInfo = psi;

                process.Start();
                StreamReader reader = process.StandardOutput;
                logger.Log("Waiting for speedtest to finish...", logger.STATUS_INFO);
                while (!process.HasExited)
                {
                    Thread.Sleep(1000);
                }

                Root result = JsonConvert.DeserializeObject<Root>(reader.ReadToEnd());

                using (StreamWriter sw = new StreamWriter(OutputPath))
                {
                    logger.Log("Writing last scan data to file...", logger.STATUS_INFO);
                    sw.Write(JsonConvert.SerializeObject(result, Formatting.Indented));
                }

                using (StreamWriter sw = new StreamWriter(CSVPath, true))
                {
                    logger.Log("Writing to Values.csv");
                    sw.WriteLine(result.ToCSV());
                }

                logger.Log($"Test {TestCounter} complete", logger.STATUS_INFO);
            }
            catch (Exception exception)
            {
                logger.Log($"Error: {exception.Message} ({exception.HResult})", logger.STATUS_ERROR);
            }

            ScanRunning = false;
        }

        private static void CleanupTimerOnElapsed(object sender, ElapsedEventArgs e)
        {
            logger.Log("Starting weekly file clean up...", logger.STATUS_INFO);
            try
            {
                DirectoryInfo dirInf = new DirectoryInfo(PathToFolder + "/Data/");
                List<FileInfo> files = dirInf.EnumerateFiles("*.txt", SearchOption.AllDirectories).ToList();

                string currentFileName = PathToFolder + $"/Data/OutputLog_{DateTime.Now.DayOfYear}.txt";
                string dayOfWeekStr = currentFileName.Remove(0, (PathToFolder + $"/Data/OutputLog_").Length);
                dayOfWeekStr = dayOfWeekStr.Remove(dayOfWeekStr.Length - 4, 4);
                int dayOfWeek = int.Parse(dayOfWeekStr);

                foreach (FileInfo fInf in files)
                {
                    if(!fInf.Name.Contains("OutputLog")) continue;

                    string fileDayOfWeekStr = fInf.Name.Remove(0, "OutputLog_".Length);
                    fileDayOfWeekStr = fileDayOfWeekStr.Remove(fileDayOfWeekStr.Length - 4, 4);
                    int fileDayOfWeek = int.Parse(fileDayOfWeekStr);

                    if (fileDayOfWeek != dayOfWeek)
                    {
                        logger.Log($"Deleting {fInf.Name}", logger.STATUS_WARNING);
                        fInf.Delete();
                    }
                }

            }
            catch (Exception exception)
            {
                logger.Log("Error: " + exception.Message, logger.STATUS_ERROR);
            }

            logger.Log("Finished weekly file clean up...", logger.STATUS_OKAY);
        }
    }
}