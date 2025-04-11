using System;

namespace CodeBase
{
    //duplicates  in an array
    public class Code7
    {
        static void Main(string[] args)
        {
            //With numbers Array
            int[] num = { 1, 2, 3, 4, 4, 5, 5 };

            for (int i = 0; i < num.Length; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] == num[j])
                    {
                        Console.WriteLine("Duplicate numers are ::" + num[i]);
                    }
                }

            }

            // with  Strings array

            string[] str = { "java", "C#", "HTML", "CSS", "C#", "ASP.net", "ASP.net" };

            for (int a = 0; a < str.Length; a++)
            {
                for (int b = a + 1; b < str.Length; b++)
                {
                    if (str[a].Equals(str[b]))
                    {
                        Console.WriteLine("Duplicate string ::::" + str[a]);
                    }
                }



            }
        }
    }
}
