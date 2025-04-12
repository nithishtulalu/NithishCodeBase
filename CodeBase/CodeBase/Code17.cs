using System;

namespace CodeBase
{
    //missing   number  in  array 
    public class Code17
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 7};

            int sum1 = 0;
            int sum2 = 0;
            for(int i=0; i<arr.Length; i++)
            {
                sum1=sum1+arr[i];
            }

            for (int i = 1; i <= 7; i++)
            {
                sum2 = sum2 + i;
            }
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine("The  missing number in the give array::"+(sum2-sum1));

        }
    }
}
