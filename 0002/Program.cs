using System;
using System.IO;

/*
 * http://judge.u-aizu.ac.jp/onlinejudge/description.jsp?id=0002
 */
namespace _0002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false });

            string line;
            while ((line = Console.ReadLine()) != null)
            {
                string[] tokens = line.Split(' ');
                int a = int.Parse(tokens[0]);
                int b = int.Parse(tokens[1]);

                Console.WriteLine(Digit(a+b));
            }

            Console.Out.Flush();
        }

        static public int Digit(int num)
        {
            // Mathf.Log10(0)はNegativeInfinityを返すため、別途処理する。
            return (num == 0) ? 1 : ((int)Math.Log10(num) + 1);
        }
    }
}
