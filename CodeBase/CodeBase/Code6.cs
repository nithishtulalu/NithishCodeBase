using System;

namespace CodeBase
{
    public  class Code6
    {
        //number of  digits  in  a number 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  a  number");
            int num = int.Parse(Console.ReadLine());
            int count = 0;

            while (num > 0)
            {
                count++;
                num = num / 10;
            }
            Console.WriteLine("number of digits in number :"+count);

        }
    }
}
