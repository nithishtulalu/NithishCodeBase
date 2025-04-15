using System;
namespace CodeBase
{
    //Find the sum of digits in a number.
    public class Code35
    {
        static void Main(string[] args)
        {
            Console.WriteLine("eneter  a anumber");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            while (num > 0)
            {
                sum = sum  + num % 10;
                num = num / 10;
            }

            Console.WriteLine(sum);
        }
    }
}
