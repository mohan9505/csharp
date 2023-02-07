using System;

namespace operators
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(sizeof(double));
            Console.WriteLine(sizeof(float));
            double d = 34.56;
            object obj1 = d;
            if (obj1 is double)
            {
                Console.WriteLine("%d is of the system Double");
            }
            string str1 = "Hello World";
            object obj2 = str1;
            string str2 = (string)obj2;
            string str3 = obj2 as string;
            int i = 100;
            Console.WriteLine(i == 100 ? "Hello Vizg" : "Hello World");

            string Country1 = null;
            string Country2 = null;
            Console.WriteLine(Country1 ?? Country2);
            Country2 = "Vizag";
            Console.WriteLine(Country1 ?? Country2);
            Country1 = "Hyderabd";
            Console.WriteLine(Country1 ?? Country2);
        }       
    }
}