using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the given number");
            int num=int.Parse(Console.ReadLine());
            int i, c = 0;
            for(i=1; i<=num; i++) 
            {
                if(num%i==0) 
                {
                    c++;
                }
            }
             if(c==2)
            
                Console.WriteLine($"{num}it is a prime number");
                else
                    Console.WriteLine($"{num}it is a not prime number");
            



        }
    }
}
