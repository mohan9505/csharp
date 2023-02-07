namespace linq_object
{
    internal class Program
    {
        static void Main()
        {
            string[] colours = { "Red", "Blue", "Green", "Black", "White", "Brown", "Orange", "Purple", "Yellow", "Aqua" };
            var coll1 = from s in colours select s;
            Console.WriteLine(String.Join("    ",coll1)+ "\n");
            var coll2 = from s in colours orderby s select s;
            Console.WriteLine(String.Join("    ", coll2) + "\n");
            var coll3 = from s in colours orderby s descending select s;
            Console.WriteLine(String.Join("    ", coll3) + "\n");
            var coll4 = from s in colours where s.Length==5  select s;
            Console.WriteLine(String.Join("    ", coll4) + "\n");
            var coll5 = from s in colours where  s[0]=='B' select s;
            Console.WriteLine(String.Join("    ", coll5) + "\n");
            var coll6 = from s in colours where s.IndexOf("B")==0select s;
            Console.WriteLine(String.Join("    ", coll6) + "\n");
            var coll7 = from s in colours where s.StartsWith("B") select s;
            Console.WriteLine(String.Join("    ", coll7) + "\n");
            var coll8 = from s in colours where s. Substring(0,1)=="B"select s;
            Console.WriteLine(String.Join("    ", coll8) + "\n");
            var coll9= from s in colours orderby s select s;
            Console.WriteLine(String.Join("    ", coll9) + "\n");












        }
    }
}