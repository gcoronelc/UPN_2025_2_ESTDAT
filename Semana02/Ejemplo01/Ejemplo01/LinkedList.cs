using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo01
{
    internal class LinkedList
    {
        private Node head;
        private int count;

        public LinkedList()
        {
            head = null;
            count = 0;
        }

        public void AddFirst(string data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
            count++;
        }

        public void AddLast(string data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            count++;
        }

        public bool Remove(string data)
        {
            if (head == null)
                return false;

            if (head.Data.Equals(data))
            {
                head = head.Next;
                count--;
                return true;
            }

            Node current = head;
            while (current.Next != null)
            {
                if (current.Next.Data.Equals(data))
                {
                    current.Next = current.Next.Next;
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

        public void print()
        {
            if (count == 0)
            {
                Console.WriteLine("Lista vacia");
                return;
            }
            Console.WriteLine("La lista es:");
            Node actual = head;
            while(actual != null)
            {
                Console.WriteLine(actual.Data + "  ");
                actual = actual.Next;
            }
        }

    }
}
