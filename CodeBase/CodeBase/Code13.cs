using System;

namespace CodeBase
{
    //foctroial  of  a given  number
    public class Code13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  a  number");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine($"factorila of :{num} is {fact}");

        }

    }
}
