using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace Assignment_7Q2_OOP
{


    class Account
    {

        static void Main(string[] args)
        {

            string file = @"C:\Users\NIPUNDE\source\repos\Assignment-7Q1-OOP";
            Console.WriteLine("Enter Customer Details....");
            Console.WriteLine("Enter Account Number:");
            int Acc_Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customer Name:");
            string Customer_Name = Console.ReadLine();
            Console.WriteLine("Enter Balance:");
            int Balance = Convert.ToInt32(Console.ReadLine());


            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.Write("Customer Name:" + Customer_Name + "\nAccount Number:" + Acc_Number + "\nBalance:" + Balance);
            }
            Console.WriteLine("Saved");

            Console.WriteLine("\n\nReading Text File:::");

            using (StreamReader reader = new StreamReader(file))
            {
                Console.WriteLine(reader.ReadToEnd());
            }

            Console.ReadKey();
        }
    }
}
