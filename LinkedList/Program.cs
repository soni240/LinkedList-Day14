// See https://aka.ms/new-console-template for more information
using LinkedList;

Console.WriteLine("----- Welcome TO LinkedList -----\n");

LinkedListOps list = new LinkedListOps();
list.Add(56);
//list.Append(30);
list.Append(70);
list.InsertAtParticularPosition(1, 30);
list.Display();


