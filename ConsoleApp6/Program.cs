namespace ConsoleApp6
{
    internal class class1
    {
        public void Test1(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public void Test2(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        //static void Main(string[] args)
        //{
        //    class1 c = new class1();
        //    c.Test1();

        //}
    }

    internal class class2 : class1
    {
        public void Test3(int a ,int b)
        {
            Console.WriteLine(a+b);
        }
        public void Test4(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        static void Main(string[] args)
        {
            class2 c = new class2();
            c.Test1(100,150);
            c.Test2(200, 100);
            c.Test3(100, 50);
            c.Test4(150, 100); 


        }
    }
}