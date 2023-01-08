using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_7Q3_OOP
{
    [Serializable]
    internal class Employee
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        //emp has to define date of joining using Date
        public string Joining_Dt { get; set; }
        public double Salary { get; set; }
        public static int EmployeeCount = 0;//static member variable

        //emp has to define date of joining

        //default constructor
        public Employee()
        {
            ID = 0;
            Name = "";
            Department = "HR";
            Joining_Dt = "10, 10, 2021";
            Salary = 0.0;
            EmployeeCount += 1;
        }
        //Parameterized constructor
        public Employee(int id, string name, double salary, string JoiningDt, string department)
        {
            this.ID = id;
            this.Name = name;
            this.Department = department;
            this.Joining_Dt = JoiningDt;
            this.Salary = salary;
            EmployeeCount += 1;
        }
        public override string ToString()
        {
            return "\nEmployee Id = " + ID + "\nEmployee Name = " + Name + "\nDate of Joining = " + Joining_Dt + "\nDepartment = " + Department + "\nBasic Salary = " + Salary;
        }

        //Salary calculation 
        public virtual double CalculateSalary()
        {
            return Salary;
        }
    }


}
