using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
   
        class Employee
        {
            int EmpNo;
            string EmpName;
            double Salary;
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
            public double NETSALARY { get; set; }
            public double GROSSSALARY { get; set; }
            //To initialize the data members of an class 
            //this 
            public void Accept(int empno, string empname, double salary)
            {
                this.EMPNO = EMPNO;
                this.EMPNAME = empname;
                this.SALARY = salary;
            }
            //member function
            public void CalculateGross()
            {
                if (SALARY < 5000)
                {
                    HRA1 = SALARY / 10;
                    TA1 = SALARY / 5;
                    DA1 = SALARY / 15;
                }
                else if (SALARY < 10000)
                {
                    HRA1 = SALARY / 15;
                    TA1 = SALARY / 10;
                    DA1 = SALARY / 20;
                }
                else if (SALARY < 15000)
                {
                    HRA1 = SALARY / 20;
                    TA1 = SALARY / 15;
                    DA1 = SALARY / 25;
                }
                else if (SALARY < 20000)
                {
                    HRA1 = SALARY / 25;
                    TA1 = SALARY / 20;
                    DA1 = SALARY / 30;
                }
                else if (SALARY >= 20000)
                {
                    HRA1 = SALARY / 30;
                    TA1 = SALARY / 25;
                    DA1 = SALARY / 35;
                }
                GrossSalary = SALARY + HRA1 + TA1 + DA1;
            }
            //Member functions
            public virtual void CalculateSalary()
            {
                PF1 = GrossSalary / 10;
                TDS1 = GrossSalary / 18;
                NetSalary = GrossSalary - (PF1 + TDS1);
            }
            public void display()
            {
                Console.WriteLine("/nThe Emp No is     :   " + EMPNO);
                Console.WriteLine("/nThe Emp Name is     :   " + EMPNAME);
                Console.WriteLine("/nThe Salary is     :   " + SALARY);
                Console.WriteLine("/n_________________________________________");
                Console.WriteLine("/nThe HRA is     :   " + HRA1);
                Console.WriteLine("/nThe TA is     :   " + TA1);
                Console.WriteLine("/nThe DA is     :   " + DA1);
                Console.WriteLine("/nThe Gross Salary is     :   " + GrossSalary);
                Console.WriteLine("/nThe PF is     :   " + PF1);
                Console.WriteLine("/nThe TDS is     :   " + TDS1);
                Console.WriteLine("/nThe Net Salary is     :   " + NetSalary);
                Console.WriteLine("/n---------------------------------");
                Console.WriteLine("/n----------------------------------");
            }
        }




        class Manager : Employee
        {

            double Petrol_A;
            double Food_A;
            double Other_A;
            double gs;

            public new void CalculateGross()
            {
                Petrol_A = SALARY / 8;
                Food_A = SALARY / 13;
                Other_A = SALARY / 13;


                base.CalculateGross();
                gs = GROSSSALARY;
                GROSSSALARY = GROSSSALARY + Petrol_A + Food_A + Other_A;
            }
            public override void CalculateSalary()
            {
                PF1 = gs / 10;
                TDS1 = gs / 18;
                NETSALARY = gs - (PF1 + TDS1);
            }
            public new void display()
            {
                Console.WriteLine("/nThe Emp No is     :   " + EMPNO);
                Console.WriteLine("/nThe Emp Name is     :   " + EMPNAME);
                Console.WriteLine("/nThe Salary is     :  " + SALARY);
                Console.WriteLine("/n_________________________________________");
                Console.WriteLine("/nThe Petrol Allowance is     :   " + Petrol_A);
                Console.WriteLine("/nThe Food Allowance is     :   " + Food_A);
                Console.WriteLine("/nThe Other Allowance is     :   " + Other_A);
                Console.WriteLine("/nThe HRA is     :   " + HRA1);
                Console.WriteLine("/nThe TA is     :   " + TA1);
                Console.WriteLine("/nThe DA is     :   " + DA1);
                Console.WriteLine("/nThe Gross Salary is     :   " + GROSSSALARY);
                Console.WriteLine("/nThe PF is     :   " + PF1);
                Console.WriteLine("/nThe TDS is     :   " + TDS1);
                Console.WriteLine("/nThe Net Salary is     :   " + NETSALARY);
                Console.WriteLine("/n---------------------------------");
                Console.WriteLine("/n----------------------------------");
            }
        }

        class MarketingExecutive : Employee
        {
            double Km_Travel;
            double Tel_A;
            double Tour_A;
            double gs;
            public new void CalculateGross()
            {
                Console.WriteLine("Enter Travel distance in KM: ");
                Km_Travel = Convert.ToInt32(Console.ReadLine());

                Tel_A = 1000;
                Tour_A = Km_Travel * 5;
                base.CalculateGross();
                gs = GROSSSALARY;
                GROSSSALARY = GROSSSALARY + Tel_A + Tour_A;
            }
            public override void CalculateSalary()
            {
                PF1 = GROSSSALARY / 10;
                TDS1 = GROSSSALARY / 18;
                NETSALARY = GROSSSALARY - (PF1 + TDS1);
            }
            public new void display()
            {
                Console.WriteLine("/nThe Emp No is     :   " + EMPNO);
                Console.WriteLine("/nThe Emp Name is     :   " + EMPNAME);
                Console.WriteLine("/nThe Salary is     :   " + SALARY);
                Console.WriteLine("/n_________________________________________");
                Console.WriteLine("/nThe Petrol Allowance is      : " + Km_Travel);
                Console.WriteLine("/nThe Telephone Allowance is      : " + Tel_A);
                Console.WriteLine("/nThe Tour Allowance is     :   " + Tour_A);
                Console.WriteLine("/nThe HRA is     :   " + HRA1);
                Console.WriteLine("/nThe TA is     :   " + TA1);
                Console.WriteLine("/nThe DA is     :   " + DA1);
                Console.WriteLine("/nThe Gross Salary is     :   " + GROSSSALARY);
                Console.WriteLine("/nThe PF is     :   " + PF1);
                Console.WriteLine("/nThe TDS is     :   " + TDS1);
                Console.WriteLine("/nThe Net Salary is     :   " + NETSALARY);
                Console.WriteLine("/n---------------------------------");
                Console.WriteLine("/n----------------------------------");
            }
        }


        

        interface IPrintable
        {
            public void display();
        }


    
}


