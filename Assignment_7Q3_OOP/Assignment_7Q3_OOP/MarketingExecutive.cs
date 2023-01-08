using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_7Q3_OOP
{
    [Serializable]
    class MarketingExecutive : Employee
    {

        public double commission { get; set; }
        public double PetrolAllowance { get; set; }
        public double TotalSalary { get; set; }

        //Calling base class No parameter Constructor 
        public MarketingExecutive() : base()
        {
            commission = 0.0;
            PetrolAllowance = 0.0;
        }
        //Calling base class's parameterized Constructor 
        //and passing parameters of base class(Employee)
        //Using Base class Constructor
        public MarketingExecutive(int id, String name, string JoiningDt, string department, double salary, double FoodAllowance, double OtherAllowance)
           : base(id, name, salary, JoiningDt, department)
        {

            this.commission = commission;
            this.PetrolAllowance = PetrolAllowance;
        }

        //Ovrriding CalculateSalary() method of base class(Enployee) 

        public override double CalculateSalary()
        {
            TotalSalary = base.Salary + PetrolAllowance + commission;
            return TotalSalary;
        }

        //Overriding ToString Method for string representation of an object
        public override string ToString()
        {
            return base.ToString() + "\ncommission = " + commission + "\nPetrolAllowance = " + PetrolAllowance + "\nTotal Salary = " + CalculateSalary();
        }
    }

}