using System;

namespace CodeBase
{
    //fibonaci  sirise 
    public class Code11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the  end number");
            int num = int.Parse(Console.ReadLine());

            int first = 0;
            int second = 1;

            for (int i = 0; i <= num; i++)
            {
                int next = first + second;
                Console.Write(next + " ");
                first = second;
                second = next;

            }
        }

        }
 }
