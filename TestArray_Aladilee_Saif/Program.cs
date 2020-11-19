using System;


namespace TestArray_Aladilee_Saif
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr2 = { 6, 7, 8, 9, 10 };

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = arr2[i];
                Console.WriteLine($"{arr1[i]}");
            }
            Console.WriteLine();
            for (int j = 0; j < arr2.Length; j++)
            {
                arr2[j] = arr1[j];
                Console.WriteLine($"{arr2[j]}");
            }
        }      
    }
}
