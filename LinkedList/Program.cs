// See https://aka.ms/new-console-template for more information

Console.WriteLine("----- Welcome TO LinkedList -----\n");

LinkedListOps list = new LinkedListOps();
list.Add(56);
list.Append(30);
list.Append(70);
Console.WriteLine("\n>>> Before Pop :-");
list.Display();
list.PopLast();
Console.WriteLine("\n>>> After PopLast :- ");
list.Display();

