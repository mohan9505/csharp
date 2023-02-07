namespace fieldsandvariables
{
    internal class classtypes
    {


        static int x;
        static void Main()
        {
            Console.WriteLine("Field x value is :" + x + "and its type is:" + x.GetType());
            int y = 10;
            Console.WriteLine("variable y value is :" + y + "and its type is:" + y.GetType());
            float f = 3.14f;
            Console.WriteLine("variable f value is :" + f + "and its type is:" + f.GetType());
            double d = 3.14;
            Console.WriteLine("variable d value is :" + d + "and its type is:" + d.GetType());
            decimal de = 3.14m;
            Console.WriteLine("variable de value is :" + de + "and its type is:" + de.GetType());
            bool b = true;
            Console.WriteLine("variable b value is :" + b + "and its type is:" + b.GetType());
            char ch = 'A';
            Console.WriteLine("Variable ch value is :" + ch + "and its type is:" + ch.GetType());



        }
    }
}




