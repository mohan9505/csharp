namespace kittu.cs
{

        internal class Program
        {
            static void Add()
            {
                int a = 20;
                int b = 30;
                int c = a + b;
                Console.WriteLine(c = a + b);

            }

            public void Sub()
            {
                int a = 20;
                int b = 30;
                int c = a - b;
                Console.WriteLine(c = a - b);
            }


            //public Program()
            //{
            //    int a = 20;
            //    int b = 30;
            //    int c = a + b;
            //    Console.WriteLine(c = a * b);


            //}
        static void Main(string[] args)
            {
                Program mh = new Program();
                Program.Add();
                mh.Sub();
                Console.ReadLine();



            }
        
        }
    }
