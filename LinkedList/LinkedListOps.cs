using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListOps
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;

                while (temp.next != null)
                {
                    temp = temp.next;

                }
                temp.next = node;

            }

            Console.WriteLine(">>> {0} is added to LinkedList...", data);

        }

        internal void Display()
        {
            Node temp = this.head;

            if (temp == null)
            {
                Console.WriteLine("\n>> Your LinkedList is Empty....");
                return;
            }
            else
            {
                Console.Write("\nLinkedList :- { ");

                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine("}");


            }
        }

    }
}

