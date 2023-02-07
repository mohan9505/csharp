

namespace ConsoleApp10
{
    internal class Constructor
    {
        public Constructor()
        {
            Console.WriteLine("constructor is called");
        }
        public void Demo()
        {
            Console.WriteLine("Method is called");
        }
        static void Main()
        {
            Constructor b1 = new Constructor();
            Constructor b2 = new Constructor();
            Constructor b3 = b2;
            b1.Demo();
            b2.Demo();
            b3.Demo();
            Console.ReadLine();
        }
    }




}
