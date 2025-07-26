using System;
using System.Linq;

namespace CodeBase
{
    //Count  Vowels in  a string ==AEIOU
    public class Code38
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter A String");
            string str= Console.ReadLine().ToUpper();
            int count = 0;
            char[] vowels = { 'A', 'E', 'I', 'O', 'U' };

            foreach (char  c in str)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }


            Console.WriteLine("Vowels  count "+count);
        }
    }
}
