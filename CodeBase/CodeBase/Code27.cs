using System;

namespace CodeBase
{
    // Prime numbers within a range
    public class Code27
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a start number:");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter an end number:");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine($"Prime numbers between {start} and {end} are:");

            for (int i = start; i <= end; i++)
            {
                bool isPrime = true;

                if (i <= 1)
                {
                    isPrime = false;
                }
                else
                {
                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                if (isPrime)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
