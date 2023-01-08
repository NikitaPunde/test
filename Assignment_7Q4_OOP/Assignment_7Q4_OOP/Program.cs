using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Assignment_7Q4_OOP
{
    [Serializable]
    class Program
    {

        public int ID;
        public string Name;
        public double Salary;
        static void Main(string[] args)
        {
            Program obj = new Program();

            Console.WriteLine("Enter the number of Employees you want to Store:");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter Manager ID:");
                int id = Convert.ToInt32(Console.ReadLine());
                obj.ID = id;
                Console.WriteLine("Enter Manager Name:");
                string nm = Console.ReadLine();
                obj.Name = nm;
                Console.WriteLine("Enter Manager Salary:");
                double sal = Convert.ToDouble(Console.ReadLine());
                obj.Salary = sal;

            }

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\Users\NIPUNDE\source\repos\Assignment-7Q1-OOP", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, obj);
            stream.Close();

            stream = new FileStream(@"C:\Users\NIPUNDE\source\repos\Assignment-7Q1-OOP", FileMode.Open, FileAccess.Read);
            Program objnew = (Program)formatter.Deserialize(stream);

            Console.WriteLine(objnew.ID);
            Console.WriteLine(objnew.Name);
            Console.WriteLine(objnew.Salary);

            Console.ReadKey();
        }

    }
}