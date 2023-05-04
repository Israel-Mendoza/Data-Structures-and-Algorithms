var ll = new MyLinkedList<int>(10);
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

var temp = ll.Pop();
Console.WriteLine(temp?.Value); // 50
ll.PrintListItems();
// --------------------------------------------------
// List's length: 4
// Head: '10' - Tail: '40'
// List's contents: [ 10 20 30 40 ]
// --------------------------------------------------

temp = ll.Pop();
Console.WriteLine(temp?.Value); // 40
ll.PrintListItems();
// --------------------------------------------------
// List's length: 3
// Head: '10' - Tail: '30'
// List's contents: [ 10 20 30 ]
// --------------------------------------------------

temp = ll.Pop();
Console.WriteLine(temp?.Value); // 30
ll.PrintListItems();
// --------------------------------------------------
// List's length: 2
// Head: '10' - Tail: '20'
// List's contents: [ 10 20 ]
// --------------------------------------------------

temp = ll.Pop();
Console.WriteLine(temp?.Value); // 20
ll.PrintListItems();
// --------------------------------------------------
// List's length: 1
// Head: '10' - Tail: '10'
// List's contents: [ 10 ]
// --------------------------------------------------

temp = ll.Pop();
Console.WriteLine(temp?.Value); // 10
ll.PrintListItems();
// --------------------------------------------------
// List's length: 0
// Head: 'null' - Tail: 'null'
// List's contents: [ ]
// --------------------------------------------------

temp = ll.Pop();
Console.WriteLine($"Popped value: '{temp?.Value}'"); // Popped value: ''


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
    // Two edge cases:
    // 1. We have an empty list.
    // 2. We have one single item in the list.
    {
        if (Head == null) // If the list is empty:
            return null;
        else if (Length == 1) // If we have one single item in the list:
        {
            Node<T>? tempNode = Head; // Keeping a copy of the tail.
            Head = null; // Making the list empty.
            Tail = null; // Making the list empty.
            Length = 0; // Making the list empty.
            return tempNode;
        }
        else // If we have more than one item in the list:
        {
            Node<T> tempNode = Head; // Creating a temporary node to hold the iteration.
            Node<T> returnNode; // Placeholder for the Node that is to be returned.
            while (true)
            {
                // If we've found the second-to-last node:
                if (tempNode.Next!.Next == null) // Forgiving null, since we know there is at least two Next valid nodes.
                {
                    returnNode = tempNode.Next; // Save a reference to the soon-to-be-popped item.
                    tempNode.Next = null; // Setting the current node as the last one.
                    Tail = tempNode; // Moving the tail's reference to the current node.
                    Length -= 1; // Decrease the size of the list.
                    return returnNode;
                }
                else
                {
                    tempNode = tempNode.Next; // Move the tempNode forward.
                }
            }
        }
    }
}
