using System;

namespace CodeBase
{
    //find first and second  largest elemnt in array
    public class Code21
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            int FIRSTMAX = 0;
            int SECONDMAX = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > FIRSTMAX)
                {
                    SECONDMAX = FIRSTMAX;
                    FIRSTMAX = numbers[i];
                }
                else if(numbers[i] < SECONDMAX)
                {
                    SECONDMAX = numbers[i];
                }
            }

            Console.WriteLine("first max::" + FIRSTMAX);
            Console.WriteLine("second Max::"+SECONDMAX);
        }
    }
}
