

namespace ConsoleApp10
{
    internal class ParamConDemo
    {
        public ParamConDemo(int i)
        {
            Console.WriteLine($"Parameterized constructor is called:{i}");
        }
        static void Main()
        {
            ParamConDemo cd1 = new ParamConDemo(100);
            ParamConDemo cd2 = new ParamConDemo(200);
            ParamConDemo conDemo = new ParamConDemo(300);
            Console.ReadLine();
        }
    }
}
