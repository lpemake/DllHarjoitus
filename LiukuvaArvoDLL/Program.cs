using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FilteringMethods;

namespace LiukuvaArvoDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gen = new Random();
            int time = 0;
            // 1.
            TextWriter tw = new StreamWriter(@"C:\tmp\data.txt");

            Filter f = FilterFactory.CreateFilter(FilterTypes.Average, 20);

            while (time < 3600)
            {
                double x = 10.0 * Math.Sin(time / 50.0);
                // lisätään kohina
                x += 4.0 * gen.NextDouble();
                if (time % 50 == 0)
                {
                    x += 30;
                }
                // lisätään uusi alkio jonon loppuun
                f.Insert(x);

                double keskiarvo = f.Calculate();

                Console.WriteLine("{0:F2}\t{1:F2}\t{2:F2}",
                    time, x, keskiarvo);
                // 2. 
                tw.WriteLine("{0:F2}\t{1:F2}\t{2:F2}",
                    time, x, keskiarvo);

                time++;
            }
            // 3.
            tw.Close();

        }
    }
}
