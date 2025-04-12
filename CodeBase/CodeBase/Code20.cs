using System;
using System.Collections.Generic;

namespace CodeBase
{
    public class Code20
    {
        // remove duplicates in  array
        static void Main(string[] args)
        {
            string[] strings = { "C#", "web api", "mvc", "C#", "web api" };

            HashSet<string> set = new HashSet<string>();
            foreach (string s in strings)
            {
                set.Add(s);
            }

            foreach (Object i in set)
            {
                Console.WriteLine(i);
            }
            

        }
    }
}
