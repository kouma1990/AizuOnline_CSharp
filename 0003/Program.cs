using System;
using System.IO;

/*
 * http://judge.u-aizu.ac.jp/onlinejudge/description.jsp?id=0003
 */
namespace _0003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false });

            int lines = int.Parse(Console.ReadLine());
            string line;
            for(int i=0; i<lines; i++)
            {
                line = Console.ReadLine();
                int[] inputs = Array.ConvertAll(line.Split(' '), new Converter<string, int>( s => int.Parse(s)) );
                Array.Sort(inputs);
                int a = inputs[0];
                int b = inputs[1];
                int c = inputs[2];

                if (a * a + b * b == c * c)
                {
                    Console.WriteLine("YES");
                } else
                {
                    Console.WriteLine("NO");
                }
            }

            Console.Out.Flush();
        }
    }
}
