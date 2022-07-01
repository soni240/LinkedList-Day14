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

            Console.WriteLine("> {0} is added to LinkedList...", data);

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


                Console.WriteLine("> {0} is appended to LinkedList...", data);

            }

        }


        internal Node InsertAtParticularPosition(int position, int data)
        {
            Node newNode = new Node(data);

            //if (position < 1)
            //     Console.WriteLine("Invalid position");   // this will make linked list index start from 1 explicitly

            int count = Size(); //calling Size method to give condtion to position

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

            Console.WriteLine("\n>> {0} is inserted at {1} position in LinkedList....\n", data, position);
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
            Console.WriteLine("\n> Serching For Element {0}... .. .", value);

            Node temp = this.head;
            int count = 0;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine("\n>> Element Found in LinkedList :- Position = {0} , Value = {1} ", count, value);
                    return temp;
                }
                temp = temp.next;
                count++;
            }
            Console.WriteLine("\n>> Element not found in LinkedList!!!..");
            return default;
        }


        public Node SearchandInsert(int searchValue)
        {
            SearchTestCase(searchValue);

            Console.Write("\n> Enter the Value You want to insert :-");
            int InsertValue = Int32.Parse(Console.ReadLine());
            Console.Write("\n> Enter the Position at which you want to insert your value :-");
            int PositionValue = Int32.Parse(Console.ReadLine());

            return InsertAtParticularPosition(PositionValue, InsertValue);

        }


        public void DeleteElement(int valuetobeDeleted)
        {
            SearchTestCase(valuetobeDeleted);
            Node temp = head;
            if (temp.data == valuetobeDeleted)
            {
                head = temp.next;
            }
            else

                while (temp.next != null)
                {

                    if (temp.next.data == valuetobeDeleted)
                    {
                        temp.next = temp.next.next;
                        Console.WriteLine("\n>> Data {0} has been deleted from linked list", temp.data);
                        int sizeofList = Size();
                        Console.WriteLine("\n>> Current Size of the LinkedList is :- " + sizeofList);
                        return;
                    }
                    else
                        temp = temp.next;

                }


        }

        public void Sort()
        {
            Node i, j;
            int temp;
            for (i = this.head; i.next != null; i = i.next)
            {
                for (j = i.next; j != null; j = j.next)
                {
                    if (i.data > j.data)
                    {
                        temp = i.data;
                        i.data = j.data;
                        j.data = temp;
                    }
                }
            }
        }

        public int Size()
        {
            int count = 0;
            Node temp = this.head;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
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
                Console.Write("\n>>> LinkedList :- { ");

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
