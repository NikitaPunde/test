using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_5CF_Q4
{
    //class MyStack
    //{
    //}
    class MyStack<T>
    {
        int capacity;
        T[] stack;
        int top;

        public MyStack(int MaxElements)

        {

            capacity = MaxElements;

            stack = new T[capacity];



            //initialize top with -1

        }



        public int push(T Element)

        {

            //Check Overflow

            if (top == capacity - 1)

            {

                // return -1 if over flow is there

                return -1;

            }

            else

            {

                // insert elementt into stack

                top = top + 1;

                stack[top] = Element;

            }

            return 0;

        }



        public T pop()

        {

            T RemovedElement;

            T temp = default(T);

            //check Underflow

            if (!(top <= 0))

            {

                RemovedElement = stack[top];

                top = top - 1;

                return RemovedElement;

            }

            return temp;



        }



        //public T peep(int position)

        //{

        //    T temp = default(T);

        //    //check if Position is Valid or not

        //    if (position < capacity && position >= 0)

        //    {

        //        return stack[position];

        //    }

        //    return temp;

        //}



        public T[] GetAllStackElements()

        {

            T[] Elements = new T[top + 1];

            Array.Copy(stack, 0, Elements, 0, top + 1);

            return Elements;

        }

    }
}
