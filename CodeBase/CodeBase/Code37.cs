using System;

namespace CodeBase
{
    public class Code37
    {
        //Find the second smallest element in an array
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int firstmin = int.MaxValue;
            int secondmin = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < firstmin) { firstmin = arr[i]; }
                else if (arr[i] < secondmin && secondmin != firstmin)
                {
                    secondmin = arr[i];
                }

            }
            Console.WriteLine("Second Minmum Number:" + secondmin);
        }
    }
}
