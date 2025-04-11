using System;

namespace CodeBase
{
    //sum of elements  in array
    public class Code14
    {
        static void Main(string[] args)
        {
            int[] numarr = { 10, 20, 30, 31, 32, 35 };
            int sum = 0;
            for (int i = 0; i < numarr.Length; i++)
            {
                sum += numarr[i];

            }
            Console.WriteLine("The Sum of  array"+sum);
        }
    }
}
