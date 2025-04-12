using System;

namespace CodeBase
{
    //find first and second  smallest   elemnt in array
    public class Code23
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            int firstmin = int.MaxValue;
            int secondmin = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < firstmin)
                {
                    firstmin = secondmin;
                    secondmin = arr[i];
                }
                else if(arr[i] < secondmin && arr[i] != firstmin)
                {
                    secondmin = arr[i];
                }
            }
            Console.WriteLine("first min::" + firstmin);
            Console.WriteLine("Second min::" + secondmin);
        }
    }
}
