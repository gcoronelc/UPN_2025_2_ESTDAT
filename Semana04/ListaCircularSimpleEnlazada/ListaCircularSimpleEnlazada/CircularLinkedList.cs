using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCircularSimpleEnlazada
{
    internal class CircularLinkedList
    {
        private Node head;
        private int count;

        public CircularLinkedList()
        {
            head = null;
            count = 0;
        }

        public void AddFirst(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
                head.Next = head;
            }
            else
            {
                newNode.Next = head;
                Node current = head;
                while (current.Next != head)
                {
                    current = current.Next;
                }
                current.Next = newNode;
                head = newNode;
            }
            count++;
        }

        public void AddLast(int data)
        {
            AddFirst(data);
            Node current = head;
            while (current.Next != head)
            {
                current = current.Next;
            }
            current.Next = head;
        }

        public bool Remove(int data)
        {
            Node current = head;

            if (head == null)
                return false;

            if (head.Data == data)
            {
                if (head.Next == head)
                {
                    head = null;
                }
                else
                {
                    current = head;
                    while (current.Next != head)
                    {
                        current = current.Next;
                    }
                    current.Next = head.Next;
                    head = head.Next;
                }
                count--;
                return true;
            }

            current = head;
            while (current.Next != head)
            {
                if (current.Next.Data == data)
                {
                    if (current.Next.Next == head)
                    {
                        current.Next = head;
                    }
                    else
                    {
                        Node prev = head;
                        while (prev.Next.Next != head)
                        {
                            prev = prev.Next;
                        }
                        prev.Next = current.Next;
                    }
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
            do
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            } while (current != head);
            Console.WriteLine();
        }
    }
}
