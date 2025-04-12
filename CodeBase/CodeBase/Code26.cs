using System;

namespace CodeBase
{
    public class Code26
    // revers each  word in  a string  
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();

            string[] words = str.Split(new char[] { ' ' });

            for (int i = 0; i < words.Length; i++)
            {
                char[] chars = words[i].ToCharArray();
                Array.Reverse(chars);
                words[i] = new string(chars);

            }
            string result= string.Join(" ", words);
            Console.WriteLine(result);  


        }
    }
}
