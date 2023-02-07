namespace OOPSProject
{   
     class Emp      
     {
        public int id;
        public string name,job;
        public double salary;
        public bool status;

     }
    class UserDetailsTypes
    {
        public Emp GetEmpDetails(int id)
        {
            Emp emp = new Emp();
            emp.id = id;
            emp.name = "raju";
            emp.job = "manager";
            emp.salary = 5000;
            emp.status = true;
            return emp;
        }



        static void Main()
        {
            UserDetailsTypes udt = new UserDetailsTypes();
            Emp obj = udt.GetEmpDetails(1001);
            Console.WriteLine(obj.id + " " + obj.name + " " + obj.job + " " + obj.status + " " + obj.salary);
            Console.ReadLine();
        }
    }

}