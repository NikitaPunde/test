using System;
using System.Text;

namespace assignment_4_oops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            MyStack m = new MyStack();
            do
            {
                Console.WriteLine("Enter Choice:");
                Console.WriteLine("1.Push");
                Console.WriteLine("2.Pop");
                Console.WriteLine("3.Display");
                Console.WriteLine("4.Clone");
                Console.WriteLine("5.Exit");
                n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Console.WriteLine("Enter element");
                        int num = Convert.ToInt32(Console.ReadLine());
                        m.PUSH(num);
                        break;
                    case 2:
                        m.POP();
                        break;
                    case 3:
                        m.Display();
                        break;
                    case 4:
                        MyStack newStack = m.Clone() as MyStack;
                        newStack.Display();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Enter valid choice");
                        break;
                }
            } while (n < 6);
        }
    }
}



                
        
    

