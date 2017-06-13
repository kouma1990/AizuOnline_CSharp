using System;

/*
* http://judge.u-aizu.ac.jp/onlinejudge/description.jsp?id=0000
*/
    
namespace _0000
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<10; i++)
            {
                for(int j=1; j<10; j++)
                {
                    Console.WriteLine("{0}x{1}={2}", i, j, i*j);
                }
            }
        }
    }
}
