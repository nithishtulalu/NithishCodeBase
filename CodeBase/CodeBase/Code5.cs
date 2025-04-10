using System;

namespace CodeBase
{
    public class Code5
    {

        //Palindrome string
        static void Main(string[] args)
        {
            Console.WriteLine("enter  a  string");
            string str = Console.ReadLine();
            string org = str;
            string rev = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev = rev + str[i];

            }
            if (rev == org)
            {
                Console.WriteLine("Palindrome string");
            }
            else
            {
                Console.WriteLine("not   Palindrome string");
            }

        }
    }
}