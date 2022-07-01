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
        public int count = 0;
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
            count++;
            Console.WriteLine(">>> {0} is added to LinkedList...", data);

        }

        public void Append(int data)
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

            Console.WriteLine(">>> {0} is appended to LinkedList...", data);


        }


        internal Node InsertAtParticularPosition(int position, int data)
        {
            Node newNode = new Node(data);

            //if (position < 1)
            //     Console.WriteLine("Invalid position");   // this will make linked list index start from 1 explicitly

            if (position == 0)
            {

                newNode.next = head;
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (position > 1)
                {
                    if (position <= count)
                    {
                        temp = temp.next;
                        position--;
                    }
                    else
                    {
                        Console.WriteLine("\n>> LinkedList Index out of Bound !!!\nCan not Insert {0}", data);
                        return head;
                    }
                }
                newNode.next = temp.next;
                temp.next = newNode;

            }

            Console.WriteLine("\n>>> {0} is inserted at {1} position in LinkedList....\n", data, position);
            return head;
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
