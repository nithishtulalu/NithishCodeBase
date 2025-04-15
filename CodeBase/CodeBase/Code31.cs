using System;
namespace CodeBase
{
    //marage two arrays 
    public class Code31
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] arr2 = { 9, 10, 11, 12, 13, 14, 15 };
            int[] mergArray= new int[arr1.Length+ arr2.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                mergArray[i] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                mergArray[arr1.Length+i] = arr2[i];
            }

            foreach (int i in mergArray)
            {
                Console.WriteLine(i); 
            }


        }
    }
}
