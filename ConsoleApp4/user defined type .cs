


using System;
    internal class user_defined_type
{
    class Emp
    {

        public string Name;
        public double Fee;
        public string Section;
    }
    class UserDefinedTypes
    {
        public Emp GetEmpDetails()
        {
            Emp emp = new Emp();
            emp.Name = "Pmohankrishna";
            emp.Fee =22000;
            emp.Section = "Batch - 5";
            return emp;
        }
        static void Main()
        {
            UserDefinedTypes udt = new UserDefinedTypes();
            Emp obj = udt.GetEmpDetails();
            Console.WriteLine(obj.Name + "" + obj.Fee + "" + obj.Section);
            Console.ReadLine();
        }
    }
}



       
        
    

