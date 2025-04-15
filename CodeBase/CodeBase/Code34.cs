using System;

namespace CodeBase
{
    //let  a   array is  mixed of   positive and  negative numbe  now  find  the avg of   positive  num
    public class Code34
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, -1, -9, -8, -10 };
            int pos = 0;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    pos = pos + i;
                    count++;
                }
            }
            Console.WriteLine("the  avg of positive number:"+(pos/count));



        }
    }
}
