using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_5CF_Q2
{
    internal class Employee
    {
        System.Collections.ArrayList arrayList1 = new System.Collections.ArrayList();
        public void Accept(int id, string name, double salary, string JoiningDt, string department)
        {
            arrayList1.Add(id);
            arrayList1.Add(name);
            arrayList1.Add(department);
            arrayList1.Add(JoiningDt);
            arrayList1.Add(salary);
        }
        public void display()
        {
            Console.WriteLine("\nEmployee Details");
            foreach (var item in arrayList1)
            {
                Console.WriteLine(item);
            }
        }
    }
}



    

