using System;

namespace CodeBase
{
    // Check if given array is sorted in ascending order
    public class Code30
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 7, 6 };
            bool isSorted = true;

            for (int i = 0; i < num.Length - 1; i++)
            {
                if (num[i] > num[i + 1])
                {
                    isSorted = false;
                    break;
                }
            }

            if (isSorted)
                Console.WriteLine("Given array is sorted in ascending order.");
            else
                Console.WriteLine("Given array is NOT sorted.");
        }
    }
}
