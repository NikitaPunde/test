using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Assignment_7Q3_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(102, "Ram", 42344, "04, 10, 2022", "ACCOUNTS");
            Console.WriteLine(emp);
            Console.ReadKey();

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\Users\NIPUNDE\source\repos\Assignment-7Q1-OOP", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, emp);
            stream.Close();


            //manager object

            Manager manager = new Manager(100, "Shruti", "04, 10, 2022", "ACCOUNTS", 20000, 5000, 2500);
            Console.WriteLine(manager);
            Console.ReadKey();
            IFormatter formatter1 = new BinaryFormatter();
            Stream stream1 = new FileStream(@"C:\Users\NIPUNDE\source\repos\Assignment-7Q1-OOP", FileMode.Create, FileAccess.Write);

            formatter1.Serialize(stream1, manager);
            stream1.Close();

            //Marketing Executive object


            MarketingExecutive mr = new MarketingExecutive(101, "Priya", "04, 10, 2022", "Sales", 25000, 5800, 2000);
            Console.WriteLine(mr);
            Console.ReadKey();

            IFormatter formatter2 = new BinaryFormatter();
            Stream stream2 = new FileStream(@"C:\Users\NIPUNDE\source\repos\Assignment-7Q1-OOP", FileMode.Create, FileAccess.Write);

            formatter2.Serialize(stream2, mr);
            stream2.Close();

        }
    }
}