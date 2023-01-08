using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Assignment_7Q1_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = (@"C:\Users\NIPUNDE\source\repos\Assignment-7Q1-OOP");

            var dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);
            var files = Directory.GetFiles(rootPath, "*.txt", SearchOption.AllDirectories);

            Console.WriteLine("***************Directories***************");
            Console.Write("\n");
            foreach (string dir in dirs)
            {
                var dirInfo = new DirectoryInfo(dir);
                Console.WriteLine($"{dirInfo.FullName}");
            }
            Console.WriteLine("\n***************All .txt files***************");
            Console.Write("\n");
            foreach (string file in files)
            {
                var fileInfo = new FileInfo(file);
                Console.WriteLine($"{Path.GetFileName(file)} - { fileInfo.Length } bytes");
            }
        }
    }
}