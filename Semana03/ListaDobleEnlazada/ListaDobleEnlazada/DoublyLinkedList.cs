using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDobleEnlazada
{
    internal class DoublyLinkedList
    {

        private Node head;
        private Node tail;
        private int count;

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public void AddFirst(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Previous = newNode;
                head = newNode;
            }
            count++;
        }

        public void AddLast(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Previous = tail;
                tail.Next = newNode;
                tail = newNode;
            }
            count++;
        }

        public bool Remove(int data)
        {
            if (head == null)
                return false;

            if (head.Data == data)
            {
                head = head.Next;
                if (head != null)
                    head.Previous = null;
                else
                    tail = null;
                count--;
                return true;
            }

            Node current = head;
            while (current.Next != null)
            {
                if (current.Next.Data == data)
                {
                    current.Next = current.Next.Next;
                    if (current.Next != null)
                        current.Next.Previous = current;
                    else
                        tail = current;
                    count--;
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        public int Count
        {
            get { return count; }
        }

        public void PrintList()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
