using System;
class Sum
{
static void Main()
{
Console.Clear();

Console.Write("enter the 1st number\n");
double d1=Convert.ToDouble(Console.ReadLine());

Console.Write("enter the 2nd number\n");
double d2=Double.Parse(Console.ReadLine());
double d3=d1+d2;
double d4=d1*d2;
Console.WriteLine(""+d1+" + "+d2+" ="+d3 );
Console.WriteLine(" {0} * {1}= {2}",d1,d2,d4);
Console.WriteLine($"divideof {d1} and {d2} ={d1/d2}" );

}
}