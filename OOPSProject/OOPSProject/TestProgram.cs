namespace OOPSProject
{
    internal class TestProgram
    {
        public void CallMethods()
        {
            Program p = new Program();
            p.Test1();
            Console.WriteLine();
            p.Test2(21,11);
            Console.WriteLine();
            
            Console.WriteLine(p.Test3());
            Console.WriteLine();
            Console.WriteLine(p.Test3());
            Console.WriteLine(p.Test4("hello public"));
            
        }
        static void Main()
        {
          new TestProgram().CallMethods();
          Console.ReadLine();
        }
    }
}
