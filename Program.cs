using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
                       int i, j, p;
            for (i = 5; i > 0; i--)
            {
                for (p = 5; p > i; p--)
                {
                    Console.Write(" ");
                }
                for (j = 0; j<i; j++)
                {
                    Console.Write("* ");
                }
               System.Console.WriteLine();
            }
        }
    }
}
