using System;
class VarDynamic
{
static void Main()
{
Console.Clear();
 var i=100;
Console.WriteLine(""+i+" and "+i.GetType());
var j=13.45;
Console.WriteLine(""+j+" and "+j.GetType());
var k=13.54f;
Console.WriteLine(""+k+" and "+k.GetType());
var l=12.56m;
Console.WriteLine(l.GetType());
var ch='a';
Console.WriteLine(ch.GetType());
var s="hello";
Console.WriteLine(s.GetType());
dynamic d;
d=100;
Console.WriteLine(d.GetType());
d='Z';
Console.WriteLine(d.GetType());
d=12.45f;
Console.WriteLine(d.GetType());
d=12.45;
Console.WriteLine(d.GetType());
d="hello";
Console.WriteLine(d.GetType());
}
}