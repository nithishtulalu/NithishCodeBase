using System;

namespace CodeBase
{
    //min word in a string
    public class Code29
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();

            string[] words = str.Split(' ');
            string minword = " ";
            int len = int.MaxValue;

            foreach (string word in words)
            {
                if (word.Length < len)
                {
                    len = word.Length;
                    minword = word;
                }
            }

            Console.WriteLine("Minmum word is::"+minword);
        }
    }
}