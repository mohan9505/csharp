


namespace ConsoleApp10
{
    internal class class1

    {
        static void Main()
        {
            Console.Clear();
            int x = 0;
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
                Console.WriteLine(arr[i] + "  ");
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                x += 10;
                arr[i] = x;
            }
            foreach (int i in arr)
                Console.WriteLine(i + " ");
            Console.WriteLine();
        }
    }



}
