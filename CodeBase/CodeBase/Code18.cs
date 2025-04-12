
using System;

namespace CodeBase
{
    //find minmum and maxmum  number  in  array
    public class Code18
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int min = arr[0];
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                   
                    max = arr[i];
                }
                else if (arr[i] < min)
                {
                  
                    min = arr[i];
                    
                }


            }
            Console.WriteLine("the  max number is ::" + max);
            Console.WriteLine("the  min number is ::" + min);

        }
    }
}