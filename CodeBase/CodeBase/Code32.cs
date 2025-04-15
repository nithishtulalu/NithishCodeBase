using System;

namespace CodeBase
{
    // Find second largest element in array
    public class Code32
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 };

            int firstmax = int.MinValue;
            int secondmax = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > firstmax)
                {
                    secondmax = firstmax;
                    firstmax = numbers[i];
                }
                else if (numbers[i] > secondmax && numbers[i] != firstmax)
                {
                    secondmax = numbers[i];
                }
            }

            if (secondmax == int.MinValue)
                Console.WriteLine("No second largest element found.");
            else
                Console.WriteLine("Second largest element: " + secondmax);
        }
    }
}
