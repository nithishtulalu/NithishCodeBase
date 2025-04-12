using System;

namespace CodeBase
{
    //count  number of  words in  astring
    public class Code25
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();

            string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(words.Length);

        }
    }
}
