using System;
using System.Collections.Generic;

namespace CodeBase
{
    //count character occurance
    public class Code24
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string");
            string str = Console.ReadLine();
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (dict.ContainsKey(c))

                    dict[c]++;
                else
                    dict[c] = 1;
            }

            foreach (var iteams in dict)
            {
                Console.WriteLine($"'{iteams.Key}': {iteams.Value}");
            }

        



        }
    }
   
}
