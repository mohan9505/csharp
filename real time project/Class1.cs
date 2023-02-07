using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_time_project
{
    internal class Array1
    {
        static void Main()
        {
            int sum = 0;
            int[] a = new int[5];
            a[0] = 1;
            a[1] = 2;
            a[2] = 3;
            a[3] = 4;
            a[4] = 5;
            sum = a[0] + a[1] + a[2] + a[3] + a[4];
            Console.WriteLine(sum);
        }       


    }
}
