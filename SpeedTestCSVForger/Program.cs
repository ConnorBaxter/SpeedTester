using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedTestCSVForger
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.CurrentDirectory + "/Values.csv";

            List<double> pings = new List<double>();
            List<int> downs = new List<int>();
            List<int> ups = new List<int>();

            Random rand = new Random();

            for (int i = 0; i < 50; i++)
            {
                pings.Add(rand.Next(10000, 50000) / 1000);
                downs.Add(rand.Next(1000000, 10000000));
                ups.Add(  rand.Next(1000000, 3000000));
            }

            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (var index = 0; index < pings.Count; index++)
                {
                    double p = pings[index];
                    int d = downs[index];
                    int u = ups[index];
                    sw.WriteLine(p + "," + d + "," + u);
                }
            }

        }
    }
}
