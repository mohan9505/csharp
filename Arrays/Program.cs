namespace Arrays
{
    internal class Program
    {
        static void Main()
        {
            Console.Clear();
            int x = 0;
            int[]arr= new int[8];
            for(int i=0;i<8;i++)
                Console.Write(arr[i]+"");
            Console.WriteLine();
            for (int i =0; i < 8; i++)
            {
                x += 10;
                arr[i] = x;
            }
            foreach(int i in arr)
                Console.WriteLine(i+"");
            Console.WriteLine();


        }
    }
}