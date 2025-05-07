using System;
// check  given number is  prime or not
namespace CodeBase
{
    public class Code12
    {
        //check  given  number is  prime or not
        static void Main(string[] args)
        {
            Console.WriteLine("Eneter a number");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
             
                if (num % i == 0)
                {
                    count++;
                }

            }
            if (count == 2)
            {
                Console.WriteLine("prime number");
            }
            else
            {
                Console.WriteLine("not prime prime number");
            }


        }
    }
}
