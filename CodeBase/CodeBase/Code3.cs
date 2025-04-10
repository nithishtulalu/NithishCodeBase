using System;

namespace CodeBase
{
    //revers a String
    public class Code3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter  a  string");
            string str = Console.ReadLine();
            String rev = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev = rev + str[i];

            }
            Console.WriteLine(rev);
        }
    }
    }
