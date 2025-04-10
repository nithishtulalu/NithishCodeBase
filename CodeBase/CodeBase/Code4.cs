using System;

namespace CodeBase
{
    public class Code4
    {

        //Palindrome number 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a  number");
            int num = int.Parse(Console.ReadLine());
            int original = num;
            int rev = 0;
            while (num > 0)
            {
                rev = rev * 10 + num % 10;
                num = num / 10;

            }
            Console.WriteLine(rev);
            if (rev == original)
            {
                Console.WriteLine("given  number is   palndrom  number");
            }
            else
            {

                Console.WriteLine("given  number is  not  palndrom  number");
            }

        }
    }
}
