using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DsaPractice.Stack
{
    public class Queue
    {
        private int[] queueArray;
        private int rear;
        private int front;
        private int maxSize;
        private int noOfItems;

        public Queue(int size)
        {
            queueArray = new int[size];
            rear = -1;
            front = 0;
            noOfItems = 0;
            maxSize = size;
        }

        public void Enqueue(int item)
        {
            if (isFull())
            {
                Console.WriteLine("The queue is full!");
                return;
            }
            rear = (rear + 1) % maxSize;
            queueArray[rear] = item;
            noOfItems++;
        }

        public int Dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("The queue is empty!");
                return -1;
            }
            int item = queueArray[front];
            front = (front + 1) % maxSize;
            noOfItems--;
            return item; 
        }

        public void Display()
        {
            if (isEmpty())
            {
                Console.WriteLine("The queue is empty!");
                return;
            }
            int count = front;
            for (int i = 0; i < noOfItems; i++)
            {
                Console.WriteLine($"{queueArray[count]}");
                count = (count + 1) % maxSize;
            }
        }

        public bool isFull()
        {
            return noOfItems == maxSize;
        }

        public bool isEmpty()
        {
            return noOfItems == 0;
        }
    }
}