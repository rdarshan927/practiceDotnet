using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DsaPractice.Stack
{
    public class Stack
    {
        private int[] stackArray;
        private int top;
        private int maxSize;

        public Stack(int size)
        {
            maxSize = size;
            stackArray = new int[size];
            top = -1;
        }

        public void push(int item)
        {
            if (top == maxSize - 1)
            {
                Console.WriteLine("Stack array is full!");
                return;
            }
            stackArray[++top] = item;
        }

        public int pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("The stack is empty");
                return -1;
            }
            return stackArray[top--];
        }

        public int peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("The stack is empty");
                return -1;
            }
            return stackArray[top];
        }

        public bool isEmpty()
        {
            return top == -1;
        }

        public void display()
        {
            if (isEmpty())
            {
                Console.WriteLine("The stack is empty");
                return;
            }
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(stackArray[i]);
            }
        }
    }
}