using System;
class Switch
{
static void Main()
{
Console.WriteLine("enter the no.");
int Sno=int.Parse(Console.Readline());

switch(Sno)
{
  case 1:
Console.WriteLine("student 1");
break;
 case 2:
Console.WriteLine("student 2");
break;
 case 3:
Console.WriteLine("student 3");
break;
 case 4:
Console.WriteLine("student 4");
break;
 case 5:
Console.WriteLine("student 5");
break;
default:
Console.WriteLine("student no");
}

}
}
