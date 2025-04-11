using System;

namespace CodeBase
{
    // Count number of odd and even digits in a number
    public class Code9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            int evencount = 0;
            int oddcount = 0;

            

            while (num > 0)
            {
                int digt = num % 10;
                if (digt % 2 == 0)
                {
                    Console.WriteLine( "Even:"+digt);
                    evencount++;
                }
                else
                {
                    Console.WriteLine("odd :"+digt);
                    oddcount++;
                }
                num = num / 10;


            }

            Console.WriteLine("Even digit count: " + evencount);
            Console.WriteLine("Odd digit count: " + oddcount);
        }
    }
}
