 namespace OOPSProject
{
    internal class Program
    {
        public void Test1()
        {
            int x = 5;
            for (int i = 1; i < 11; i++)
                Console.WriteLine($"{x}*{i}={x * i}");

        }
        public void Test2(int x,int ub)
        {
            for (int i = 1; i < ub; i++)
                Console.WriteLine($"{x}*{i}={x * i}");
        }
        public string Test3()
        {
            string str = "topper mohan";
            str = str.ToUpper();
            return str;
        }
        public string Test4(string str)
        {
            
            str = str.ToUpper();
            return str;
        }
        static void Main()
        {
            Program p = new Program();
            p.Test1();
            Console.WriteLine();
            p.Test2(8,11);
            Console.WriteLine();
            string s1 = p.Test3();
            Console.WriteLine(s1);
            string s2 = p.Test4("hello world");
            Console.WriteLine(s2);
            Console.ReadLine();
        }
    }
}