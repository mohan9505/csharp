using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePass
{
    internal class Palindrome1toN
    {
        static void Main()
        {
            Console.WriteLine("enter a given range:");
            int num = int.Parse(Console.ReadLine());
            int rem, r = 0;
            int temp;
            for (int i = 1; i <= num; i++)
            {
                temp = i;
                r = 0;
                while (temp > 0)
                {
                    rem = temp % 10;
                    r = r * 10 + rem;
                    temp = temp/ 10;
                }

                if (r == i)
                    Console.WriteLine(i+" ");

            }






























           
        }


        
    }
}
