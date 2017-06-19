using System;
using System.IO;
/*
 * http://judge.u-aizu.ac.jp/onlinejudge/description.jsp?id=0004
 */
namespace _0004
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false });
            
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                string[] tokens = line.Split(' ');
                double a = double.Parse(tokens[0]);
                double b = double.Parse(tokens[1]);
                double c = double.Parse(tokens[2]);
                double d = double.Parse(tokens[3]);
                double e = double.Parse(tokens[4]);
                double f = double.Parse(tokens[5]);
                double del = a * e - b * d;
                x = Math.Round((c * e - b * f) / del, 3);
                y = Math.Round((a * f - c * d) / del, 3);

                Console.WriteLine("{0:f3} {1:f3}", x, y);
            }

            Console.Out.Flush();
        }
    }
}
