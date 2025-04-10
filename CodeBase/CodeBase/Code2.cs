using System;

namespace CodeBase
{
    //revers  a number  
    public class Code2
    {
     public static void Main(string[] args)
        {
            Console.WriteLine("enter a  number");
            int num= int.Parse(Console.ReadLine());
            int rev = 0;

            while (num > 0)
            {
                rev = rev * 10 + num % 10;
                num = num / 10;

            }
            Console.WriteLine("the   Reveres number:"+rev);
        }

    }
}
