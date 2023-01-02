using System;

namespace assignment_5CF_Q4
{
    class Program
    {
        static void Main(string[] args)
        
            {

                int capacity, ch;

                Console.WriteLine("Enter Capacity of Stack :");

                capacity = int.Parse(Console.ReadLine());



                MyStack<string> stack = new MyStack<string>(10);



                do

                {

                    Console.WriteLine("Eneter your Choice: 1.Push 2.Pop 3.Display 4.Exit");


                    ch = Convert.ToInt32(Console.ReadLine());


                    switch (ch)

                    {

                        case 1:

                            {

                                Console.WriteLine("Enter String to Push :");

                                string temp = Console.ReadLine();

                                int result = stack.push(temp);



                                if (result != -1)

                                {

                                    Console.WriteLine("Element Pushed into Stack !");

                                }

                                else

                                {

                                    Console.WriteLine("Stack Overflow !");

                                }

                                break;

                            }

                        case 2:

                            {

                                string Result = stack.pop();

                                if (Result != null)

                                {

                                    Console.WriteLine("Delete Element :" + Result);

                                }

                                else

                                {

                                    Console.WriteLine("Stack Underflow !");

                                }

                                break;

                            }



                        //case 3:

                        //    {

                        //        Console.WriteLine("Enter Position of Element to Pop:");

                        //        int Position = int.Parse(Console.ReadLine());

                        //        string Result = stack.peep(Position);



                        //        if (Result != null)

                        //        {

                        //            Console.WriteLine("Element at Position" + Position + " is " + Result);

                        //        }

                        //        else

                        //        {

                        //            Console.WriteLine("Entered Element is Out of Stack Range ");

                        //        }

                        //        break;

                        //    }

                        case 3:

                            {

                                string[] Elements = stack.GetAllStackElements();

                                Console.WriteLine("**************Stack Content **************");

                                foreach (string str in Elements)

                                {

                                    Console.WriteLine(str);

                                }

                                break;

                            }

                        case 4:
                            break;


                        default:

                            {

                                Console.WriteLine("Invalid Choice ");

                                break;

                            }

                    }

                } while (ch < 4);

            }
        }
    }
