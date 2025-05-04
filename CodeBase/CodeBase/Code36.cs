

using System;

namespace CodeBase
{
    //Find the second highest element in an array
    public class Code36
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int firstmax = arr[0];
            int secondmax = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > firstmax)
                {
                    secondmax = firstmax;
                    firstmax = arr[i];
                }
                else if (arr[i] < secondmax && secondmax != firstmax) { 
                    secondmax=arr[i];
                }
            }
            Console.WriteLine("Second max is :"+secondmax);



        }
    }
}
