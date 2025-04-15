using System;
//find  largest  word in  string 
namespace CodeBase
{
    public class Code28
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a  string");
            string str = Console.ReadLine();

            string[] words = str.Split(' ');
            string maxword = " ";
            int maxlen = 0;
            foreach (string word in words)
            {
                if(word.Length > maxlen)
                {
                    maxlen = word.Length;
                    maxword = word;
                }
            }
            Console.WriteLine("the  MAX Word::" + maxword);
        }
    }
}
