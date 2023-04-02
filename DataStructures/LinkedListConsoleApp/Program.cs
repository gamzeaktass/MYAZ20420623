using LinkedList;

var linkedlist = new SinglyLinkedList<int>();
linkedlist.AddFirst(10);
linkedlist.AddFirst(20);
linkedlist.AddFirst(30); //Son eklediğimiz head olarak başa gelir 
Console.WriteLine(linkedlist.Head);
Console.WriteLine(linkedlist.Head.Next);
Console.WriteLine(linkedlist.Head.Next.Next);
Console.WriteLine("---------------------------------------");




var node1 = new SinglyLinkedListNode<int>();
node1.Value = 55;
var node2 = new SinglyLinkedListNode<int>();
node2.Value = 60;
var node3 = new SinglyLinkedListNode<int>();
node3.Value = 65;

node1.Next = node2;
node2.Next = node3;

Console.WriteLine(node1);
Console.WriteLine(node1.Next);
Console.WriteLine(node2.Next);
Console.WriteLine(node1.Next.Next);
Console.WriteLine("---------------------------------------");

//Yukarıdaki işlemin aynısının döngülü hali
var current = node1;
while(current!= null)
{
    Console.WriteLine(current.Value);
    current = current.Next;
}




Console.ReadKey();