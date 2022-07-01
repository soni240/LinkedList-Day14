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
            if (this.head == null)
            {
                Console.WriteLine("\n>> Sorry can not perform append Operation as Your Linked List is Empty!!!..\n");

            }

            else
            {
                Node node = new Node(data);

                Node temp = head;

                while (temp.next != null)
                {
                    temp = temp.next;

                }
                temp.next = node;


                Console.WriteLine(">>> {0} is appended to LinkedList...", data);

            }

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

        internal Node Pop()
        {
            if (head == null)
                return null;
            head = head.next;
            return head;
        }

        internal Node PopLast()
        {
            if (head == null)
                return null;
            if (head.next == null)
                return null;
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }

        public Node SearchTestCase(int value)
        {
            Console.WriteLine("\n>> Serching For Element {0}... .. .", value);

            Node temp = this.head;
            int count = 0;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine("\n>>> Element Found in LinkedList :- Position = {0} , Value = {1} ", count, value);
                    return temp;
                }
                temp = temp.next;
                count++;
            }
            Console.WriteLine("\n>> Element not found in LinkedList!!!..");
            return null;
        }


        public Node SearchandInsert(int searchValue)
        {
            var x = SearchTestCase(searchValue);
            if (x != null)
            {
                Console.Write("\n>> Enter the Value You want to insert :-");
                int InsertValue = Int32.Parse(Console.ReadLine());
                Console.Write("\n>> Enter the Position at which you want to insert your value :-");
                int PositionValue = Int32.Parse(Console.ReadLine());

                return InsertAtParticularPosition(PositionValue, InsertValue);
            }

            else
                return default;
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
