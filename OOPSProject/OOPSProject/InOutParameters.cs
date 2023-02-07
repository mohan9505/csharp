
namespace OOPSProject
{
    internal class InOutParameters
    {
      
        public void factorial(ref int a)
        {
            int fact = 1;
            int temp = a;
            if (a == 0&a==1)
            {
                a = 1;

            }
            else
            {
                for(int i=2;i<=a;i++)
                {
                    fact = fact * i;
                }
                a = fact;
                
                Console.WriteLine($"factorial of {temp} is {a}");

            }
        }
        public static void Main()
        {
         InOutParameters p= new InOutParameters();
            int f = 5;
            p.factorial(ref f);
          
        }
    }
}
