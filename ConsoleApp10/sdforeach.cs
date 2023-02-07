using System;
namespace ConsoleApp10
{
    internal class Class1
    {
        static void Main()
        {
            Console.Clear();
            int[] arr = { 10, 12, 13, 14, 15, 16, 17, 18, 19, 20 }
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i] + " ");
            Console.WriteLine();
            Array.Sort(arr);
            foreach (int i in arr)
                Console.WriteLine(i + " ");
            Console.WriteLine();
            Array.Reverse(arr);
            foreach (int i in arr)
                Console.WriteLine(i + " ");
            Console.WriteLine();
            int[] brr = new int[10];
            Array.Copy(arr, brr, 7);
            foreach (int i in brr)
                Console.WriteLine(i + " ");
            Console.WriteLine();
        }
    }

    
}
