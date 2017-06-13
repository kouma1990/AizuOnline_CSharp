using System;

/*
 * http://judge.u-aizu.ac.jp/onlinejudge/description.jsp?id=0001
 */
namespace _0001
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = new int[10];
            for(int i=0; i<10; i++)
            {
                inputs[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(inputs);
            Array.Reverse(inputs);

            for(int i=0; i<3; i++)
            {
                Console.WriteLine(inputs[i]);
            }
            
        }
    }
}
