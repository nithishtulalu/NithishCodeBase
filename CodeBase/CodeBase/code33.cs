using System;

namespace CodeBase
{
    //check  if the given  array   is contines    specfic valu  or  not
    public class code33
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter  a  string that  conver into  array");
            string str = Console.ReadLine();
            Console.WriteLine("Enter search key");
            string key = Console.ReadLine();
            bool flag = false;

            string[] strarray = str.Split(' ');

            foreach (string kk in strarray)
            {
                if (kk == key) { 
                    flag = true;
                    break;

                }
            }
            if (flag)
            {
                Console.Write("key find");
            }
            else
            {
                Console.Write("key not  find");
            }



        }
    }
}
