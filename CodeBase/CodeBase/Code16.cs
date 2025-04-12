using System;

namespace CodeBase
{
    //check   given  two  arrays  are   equal  or  not
    public class Code16
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 1, 2, 3 };

            bool status=true;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] != arr2[j])
                    {
                        status = false;

                    }
                }
            }
            if (status == true)
            {
                Console.WriteLine("Both Are Same");
            }
            else
            {
                Console.WriteLine("Both Are not Same");
            }
        }


        }
 }
