using System;

namespace CodeBase
{
    public class Code1
    {
        //Swapping  two numbers  in two ways 
        static void Main(string[] args)
        {

            Console.WriteLine("Ples Enter Num1:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ples Enter Num2:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($" num1 {num1} num2 {num2}");
            //first way  using third variable
            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine($" num1 {num1} num2 {num2}");
            //without  using third variable

            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine($" num1 {num1} num2 {num2}");

        }
    }
}
