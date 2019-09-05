using System;

namespace Homework4
{
    class Program
    {
        public static long Factorial(int N)
        {
            long factorial = 1;
            if (N != 0)
            {
                for (int i = 2; i <= N; i++)
                {
                    factorial *= i;
                }
            }
            return factorial;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number N: ");
            int N = Int32.Parse(Console.ReadLine());
            if (N >= 0)
            {
                Console.WriteLine($"factorial {N}: {Factorial(N)}");
            }
            else
            {
                Console.WriteLine("a negative number was entered!");
            }
            
            Console.ReadKey();
        }
    }
}
