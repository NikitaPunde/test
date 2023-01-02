using System;
using System.Collections.Generic;
using System.Text;

namespace asssignment_2_oop_csharp
{
    class Employee
    {
        int EmpNo;
        string EmpName;
        double salary;
        double HRA;
        double TA;
        double DA;
        double PF;
        double TDS;
        double NetSalary;
        double GrossSalary;
        public int EMPNO { get; set; }
        public string EMPNAME { get; set; }
        public double SALARY { get; set; }
        public double HRA1 { get; set; }
        public double TA1 { get; set; }
        public double DA1 { get; set; }
        public double PF1 { get; set; }
        public double TDS1 { get; set; }
        public double NetSalary1 { get; set; }
        public double GrossSalary1 { get; set; }
        //To initialize the data members of an class 
        //this 
        public Employee(int EmpNo, string EmpName, double salary)
        {
            this.EMPNO = EmpNo;
            this.EMPNAME = EmpName;
            this.salary = salary;
        }
        //member function
        public void CalculateSalary()
        {
            if (salary < 5000)
            {
                HRA1 = SALARY / 10;
                TA1 = SALARY / 5;
                DA1 = SALARY / 15;
            }
            else if (salary < 10000)
            {
                HRA1 = SALARY / 15;
                TA1 = SALARY / 10;
                DA1 = SALARY / 20;
            }
            else if (salary < 15000)
            {
                HRA1 = SALARY / 20;
                TA1 = SALARY / 15;
                DA1 = SALARY / 25;
            }
            else if (salary < 20000)
            {
                HRA1 = SALARY / 25;
                TA1 = SALARY / 20;
                DA1 = SALARY / 30;
            }
            else if (salary >= 20000)
            {
                HRA1 = SALARY / 30;
                TA1 = SALARY / 25;
                DA1 = SALARY / 35;
            }
            GrossSalary = SALARY + HRA1 + TA1 + DA1;
            PF1 = GrossSalary / 10;
            TDS1 = GrossSalary / 18;
            NetSalary = GrossSalary - (PF1 + TDS1);


        }
    }
}
