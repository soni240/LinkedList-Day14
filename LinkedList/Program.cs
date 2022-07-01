// See https://aka.ms/new-console-template for more information
using LinkedList;

Console.WriteLine("----- Welcome TO LinkedList -----\n");

LinkedListOps list = new LinkedListOps();
list.Add(56);
list.Add(30);
list.Add(40);
list.Add(70);
list.Display();
Console.WriteLine("\n>> Sorted Linked List :- ");
list.Sort();
list.Display();


