using System;

namespace CodeBase
{
    //largest  among   three numbers
    public class Code10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  Num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter  Num2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter  Num3");
            int num3 = int.Parse(Console.ReadLine());


            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1 + "is gratter");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine(num2 + "is gratter");

            }

            else {
                Console.WriteLine(num3+ "is gratter");
            }
        }

    }
}
