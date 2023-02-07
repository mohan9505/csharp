using System;
class OperatorsDemo
{
static void Main()
{
Console.Clear();
Console.WriteLine(typeof(double));
Console.WriteLine(sizeof(double));

double d=34.56;
object obj1=d;
if(obj1 is double)
{
Console.WriteLine("d is of type system.Double");
}


string str1="Hello World";
object obj2=str1;
string str2=(string)obj2;
string str3=obj2 as string;


int i=100;
Console.WriteLine(i==101?"Hello India":"Hello World");

string Country1=null;
string Country2=null;
Console.WriteLine(Country1??Country2);
Country2="India";
Console.WriteLine(Country1??Country2);
Country1="America";
Console.WriteLine(Country1??Country2);




}
}
