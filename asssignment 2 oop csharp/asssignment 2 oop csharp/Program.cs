using System;



namespace asssignment_2_oop_csharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            //public void Accept()
            Console.WriteLine("Enter Employee details:");
            Console.WriteLine("Emp No:");
            int eno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Emp Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Salary:");
            double sal = Convert.ToDouble(Console.ReadLine());

            Employee emp = new Employee(eno, name, sal);
            emp.CalculateSalary();
            Console.WriteLine("\nThe Emp No is      : " + emp.EMPNO);
            Console.WriteLine("\nThe Emp Name is     :   " + emp.EMPNAME);
            Console.WriteLine("\nThe Salary is     :   " + emp.SALARY);
            Console.WriteLine("\n_________________________________________");
            Console.WriteLine("\nThe HRA is     :   " + emp.HRA1);
            Console.WriteLine("\nThe TA is     :   " + emp.TA1);
            Console.WriteLine("\nThe DA is     :   " + emp.DA1);
            Console.WriteLine("\nThe Gross Salary is     :   " + emp.GrossSalary1);
            Console.WriteLine("\nThe PF is     :   " + emp.PF1);
            Console.WriteLine("\nThe TDS is     :   " + emp.TDS1);
            Console.WriteLine("\nThe Net Salary is     :   " + emp.NetSalary1);




            //How to access the Methods outside the class
            //emp.DisplayEmpDetails();
            //Console.ReadKey();



        }
    }
}

    



