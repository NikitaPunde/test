using System;

namespace assignment_5CF_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.Accept(101, "Priya", 24000, "12 dec 2021", "Sales");
            emp1.Accept(678, "Ram", 25000, "1 mar 2021", "HR");
            emp1.Accept(117, "Vijay", 20000, "22 jul 2022", "Sales");
            emp1.display();
        }
    }
}
       
    

