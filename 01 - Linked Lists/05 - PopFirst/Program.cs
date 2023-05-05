﻿var ll = new MyLinkedList<int>(10);

ll.Append(20);
ll.Append(30);
ll.Append(40);
ll.Append(50);

ll.PrintListItems();
// --------------------------------------------------
// List's length: 5
// Head: '10' - Tail: '50'
// List's contents: [ 10 20 30 40 50 ]
// --------------------------------------------------

Node<int>? poppedItem = ll.PopFirst();
Console.WriteLine(poppedItem?.Value); // 10
ll.PrintListItems();
// --------------------------------------------------
// List's length: 4
// Head: '20' - Tail: '50'
// List's contents: [ 20 30 40 50 ]
// --------------------------------------------------

poppedItem = ll.PopFirst();
Console.WriteLine(poppedItem?.Value); // 20
ll.PrintListItems();
// --------------------------------------------------
// List's length: 3
// Head: '30' - Tail: '50'
// List's contents: [ 30 40 50 ]
// --------------------------------------------------

poppedItem = ll.PopFirst();
Console.WriteLine(poppedItem?.Value); // 30
ll.PrintListItems();
// --------------------------------------------------
// List's length: 2
// Head: '40' - Tail: '50'
// List's contents: [ 40 50 ]
// --------------------------------------------------

poppedItem = ll.PopFirst();
Console.WriteLine(poppedItem?.Value); // 40
ll.PrintListItems();
// --------------------------------------------------
// List's length: 1
// Head: '50' - Tail: '50'
// List's contents: [ 50 ]
// --------------------------------------------------

poppedItem = ll.PopFirst();
Console.WriteLine(poppedItem?.Value); // 50
ll.PrintListItems();
// --------------------------------------------------
// List's length: 0
// Head: 'null' - Tail: 'null'
// List's contents: [ ]
// --------------------------------------------------

poppedItem = ll.PopFirst();
Console.WriteLine(poppedItem?.Value); // 
ll.PrintListItems();
// --------------------------------------------------
// List's length: 0
// Head: 'null' - Tail: 'null'
// List's contents: [ ]
// --------------------------------------------------

//////////////////////////////CLASSES//////////////////////////////


class Node<T>
{
    public T Value;
    public Node<T>? Next;
    public Node(T value) { this.Value = value; this.Next = null; }
}

class MyLinkedList<T>
{
    public Node<T>? Head;
    public Node<T>? Tail;
    public int Length;
    public MyLinkedList(T value)
    {
        Node<T>? newNode = new Node<T>(value);
        Head = newNode;
        Tail = newNode;
        Length = 1;
    }
    public void PrintListItems()
    {
        Node<T>? tempNode = Head; // Creating a temp node to hold each node.
        var divider = new string('-', 50); // Divider for nice-looking output.
        Console.WriteLine(divider);
        Console.WriteLine($"List's length: {Length}");
        string? HeadString = tempNode == null ? "null" : tempNode?.Value?.ToString();
        string? TailString = Tail == null ? "null" : Tail?.Value?.ToString();
        Console.WriteLine($"Head: '{HeadString}' - Tail: '{TailString}'");
        Console.Write("List's contents: [ ");
        while (tempNode != null) // As long as we don't reach a "dead" node.
        {
            Console.Write($"{tempNode.Value} ");
            tempNode = tempNode.Next;
        }
        Console.WriteLine("]");
        Console.WriteLine(divider);
    }
    public bool Append(T value)
    {
        var newNode = new Node<T>(value);
        if (Head == null) // If the list is empty:
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Tail!.Next = newNode; // The old tail needs to point to the new node.
            Tail = newNode; // The tail needs to point to the new node.
        }
        Length += 1; // The length is increasing too.
        return true; // For future purposes ;)
    }
    public Node<T>? Pop()
    // Edge cases:
    // 1. The list is empty.
    // 2. The list has one single item.
    // 
    // If there is more than one item in the list, we'll proceed to create two
    // Node variables that will iterate over the list.
    // The first one (tempNode) will be testing whether the Node's "next"
    // attribute is pointing to "null". When it does, we will have found
    // the Node to be popped. We'll return this value.
    // The second Node (preTempNode) will point to the previous Node
    // that points to temp_node, so we can use it as the new tail.
    {

        if (Length == 0) // If the list is empty:
            return null;
        Node<T>? tempNode;
        if (Length == 1) // If we have one single item in the list:
        {
            tempNode = Head; // Keeping a copy of the tail.
            Head = null; // Making the list empty.
            Tail = null; // Making the list empty.
            Length -= 1; // Making the list empty.
        }
        else // If we have more than one item in the list:
        {
            tempNode = Head; // Creating a temporary node to hold the iteration.
            Node<T>? preTempNode = tempNode; // Placeholder for the Node that is to be returned.
            while (tempNode!.Next != null)
            {
                preTempNode = tempNode;
                tempNode = tempNode.Next;
            }
            // After the loop breaks, we will have found the last and new tail of the list.
            Tail = preTempNode;
            Tail!.Next = null;
            Length -= 1;
        }
        return tempNode;
    }

    public bool Prepend(T value)
    {
        // Edge case: the list is empty.
        Node<T> newNode = new Node<T>(value);
        if (Length == 0)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            newNode.Next = Head;
            Head = newNode;
        }
        Length += 1;
        return true;
    }

    public Node<T>? PopFirst()
    {
        // Edge cases: the list is empty or has one single item.
        if (Length == 0)
            return null;
        Node<T>? poppedItem = Head;
        if (Length == 1)
        {
            Head = null;
            Tail = null;
        }
        else
            Head = Head!.Next;
        poppedItem!.Next = null;
        Length -= 1;
        return poppedItem;
    }
}