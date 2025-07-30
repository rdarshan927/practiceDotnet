using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DsaPractice.SimpleLinkedList
{
    public class SimpleLinkedList
    {
        Node head = null;
        Node tail = null;

        public void AddLast(Object data)
        {
            Node newItem = new Node();
            newItem.data = data;

            if (head == null)
            {
                head = newItem;
                tail = head;
            }
            else
            {
                tail.next = newItem;
                tail = newItem;
            }
        }

        public void AddFirst(Object data)
        {
            Node newItem = new Node();
            newItem.data = data;

            if (head == null)
            {
                head = newItem;
                tail = head;
            }
            else
            {
                newItem.next = head;
                head = newItem;
            }
        }

        public void ReadAll()
        {
            Node current = head;

            while (current.next != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
            Console.WriteLine(current.data);
        }

        public Object Remove(Object data)
        {
            if (head == null)
                return false;

            if (head.data.Equals(data))
            {
                head = head.next;
                if (head == null)
                    tail = null;
                return true;
            }
            Node current = head;

            while (current.next.data.Equals(data))
            {
                current.next = current.next.next;

                if (current.next == null)
                    tail = current;

                return true;
            }
                return false;
        }
    }
}