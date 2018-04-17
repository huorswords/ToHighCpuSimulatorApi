using System;

namespace Swords.HighCpuJob
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"* Iteration {i}");
                FindPrimeNumber(i * 1000);
            }

            Console.WriteLine("End");
            Console.ReadLine();
        }
        
        private static long FindPrimeNumber(int n)
        {
            int count = 0;
            long a = 2;
            while (count < n)
            {
                long b = 2;
                int prime = 1;// to check if found a prime
                while (b * b <= a)
                {
                    if (a % b == 0)
                    {
                        prime = 0;
                        break;
                    }
                    b++;
                }
                if (prime > 0)
                {
                    count++;
                }
                a++;
            }
            return (--a);
        }
    }
}
