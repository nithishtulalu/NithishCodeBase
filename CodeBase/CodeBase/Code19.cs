using System;

namespace CodeBase
{
    public class Code19
    {
        static void Main(string[] args)
        {
            string[] strings = { "C#", "web api", "mvc", "C#", "web api" };

            Console.WriteLine("Duplicate elements are:");

            for (int i = 0; i < strings.Length; i++)
            {
                for (int j = i + 1; j < strings.Length; j++)
                {
                    if (strings[i] == strings[j])
                    {
                        Console.WriteLine(strings[i]);
                        break; 
                    }
                }
            }
        }
    }
}
