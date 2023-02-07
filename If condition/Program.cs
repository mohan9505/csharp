namespace If_condition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number:");
            double d1=double.Parse(Console.ReadLine());
            Console.WriteLine("enter the 2nd number:");
            double d2=double.Parse(Console.ReadLine());
            if (d1 > d2)
                Console.WriteLine("1st number is greater than 2nd number.");
            else if (d1 < d2)
                Console.WriteLine("2nd number is greater than 1st number:");
            else
                Console.WriteLine("Both the given numbers are equal:");
        }
    }
}