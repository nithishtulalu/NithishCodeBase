using System;

namespace CodeBase
{
    //removing  white  spaces in  a string
    public class Code22
    {
        static void Main(string[] args)
        {
            string str = "    Nithish kumar  Tulalu    ";
            Console.WriteLine(str.Length);
            String str2 = str.Trim();
            Console.WriteLine(str2);
            Console.WriteLine(str2.Length);


        }
    }
}
