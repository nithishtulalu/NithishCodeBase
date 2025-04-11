using System;

namespace CodeBase
{
    //print  odd even  elements  in  array
    public class Code15
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            Console.WriteLine("Even  numbers");

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    Console.WriteLine(num[i]);
                }
            }

            Console.WriteLine("odd  numbers");

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 != 0)
                {
                    Console.WriteLine(num[i]);
                }
            }

        }
    }
}