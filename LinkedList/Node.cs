using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public int data; //instance variable
        public Node next; //Referance variable

        public Node(int data)  //Default Constructor of Node class
        {
            this.data = data;   // init of instance variable
        }
    }
}
