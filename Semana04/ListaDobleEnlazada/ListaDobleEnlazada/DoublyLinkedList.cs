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
            // Crea el nuevo nodo
            Node newNode = new Node(data);

            // Cuando la lista esta vacia
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
            // Cuando esta vacio
            if (head == null)
                return false;

            // Cuando se elimina el primero
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

            // Elimina un elemento interno
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
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine( "NULL");
        }

        public void PrintListReverse()
        {
            Node current = tail;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Previous;
            }
            Console.WriteLine("NULL");
        }

        public int ExtraerDesdeInicio()
        {
            if(head == null)
            {
                throw new InvalidOperationException("La lista está vacía.");
            }
            Node current=head;
            head=current.Next;
            current.Next = null;
            if(head== null)
            {
                tail = head;
            }
            else
            {
                head.Previous = null;

            }
            return current.Data;
        }

        public int ExtraerDesdeFinal()
        {
            if (tail == null)
            {
                throw new InvalidOperationException("La lista está vacía.");
            }
            Node current = tail;
            tail = current.Previous;
            current.Previous = null;
            if (tail == null)
            {
                head = tail;
            }
            else
            {
                tail.Next = null;

            }
            return current.Data;
        }

    }
}
