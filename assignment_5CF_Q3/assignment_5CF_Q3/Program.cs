using System;
using System.Collections.Generic;
namespace assignment_5CF_Q3
{
   public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter The No. Employee details you want to enter:");
            int ch = Convert.ToInt32(Console.ReadLine());
            List<Employee> listEmployee = new List<Employee>();
            for (int i = 0; i < ch; i++)
            {
                Console.WriteLine("$Enter Employee " + i + " Detais:");
                Console.WriteLine("Enter Emp ID:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Emp name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Emp department:");
                string department = Console.ReadLine();
                Console.WriteLine("Enter Emp joining date:");
                string jdate = Console.ReadLine();
                Console.WriteLine("Enter Emp salary:");
                int salary = Convert.ToInt32(Console.ReadLine());
                Employee emp1 = new Employee() { ID = id, Name = name, Department = department, Joining_Date = jdate, Salary = salary };
            listEmployees(emp1);
            }
            //break;
            //case 2:
            Console.WriteLine("\n All Details of Employees:");
            foreach (Employee employee in listEmployee)

            {
                Console.WriteLine("Employee Details:");
                Console.WriteLine($"\nID = {employee.ID}, \nname = {employee.Name}," + $"\nDepartment = {employee.Department}, \nJoining_Date{employee.Joining_Date}," + $"\nSalary = {employee.Salary}");
            }
            Console.WriteLine($"\n\nTotal Employee Count : {listEmployee.Count}");
        }
    }
}



    

        

