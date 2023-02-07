
namespace OOPSProject
{
    class OutputParameters
    {
        public void Math1(int a,int b,out int c,out int d)
        {
            c = a + b;
            d = a * b;

        }
        public (int a,int b) Math2(int a,int b)
        {
            int c = a + b;
            int d = a * b;
            return(c,d);

        }
    static void Main()
        {
            OutputParameters p = new OutputParameters();
            int sum1, product1;
            p.Math1(12, 24,out  sum1,out  product1);
            Console.WriteLine("sum of the given number is:" + sum1);
            Console.WriteLine("product of the given numbers is: " +product1 + "\n");

            p.Math1(12, 24, out int sum2, out int product2);
            Console.WriteLine("sum of the given number is:" + sum2);
            Console.WriteLine("product of the given numbers is: " + product2 + "\n");

            (int sum3, int product3) = p.Math2(100, 120);
            Console.WriteLine("sum of the given number is:" + sum3);
            Console.WriteLine("product of the given numbers is: " + product3 + "\n");

            var (sum4, product4) = p.Math2(100,25);
            Console.WriteLine("sum of the given number is:" + sum4);
            Console.WriteLine("product of the given numbers is: " + product4 + "\n");



            Console.ReadLine();
        }
    }
}
