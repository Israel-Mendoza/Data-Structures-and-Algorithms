var ll = new MyLinkedList<int>(10);
ll.Append(20);
ll.Append(30);
ll.Append(40);
ll.Append(50);

ll.PrintListItems();
// List's length: 5
// List's contents: [ 10 20 30 40 50 ]

var temp = ll.Pop();
Console.WriteLine(temp?.Value); // 50
ll.PrintListItems();
// List's length: 4
// List's contents: [ 10 20 30 40 ]

temp = ll.Pop();
Console.WriteLine(temp?.Value); // 40
ll.PrintListItems();
// List's length: 3
// List's contents: [ 10 20 30 ]

temp = ll.Pop();
Console.WriteLine(temp?.Value); // 30
ll.PrintListItems();
// List's length: 2
// List's contents: [ 10 20 ]

temp = ll.Pop();
Console.WriteLine(temp?.Value); // 20
ll.PrintListItems();
// List's length: 1
// List's contents: [ 10 ]

temp = ll.Pop();
Console.WriteLine(temp?.Value); // 10
ll.PrintListItems();
// List's length: 0
// List's contents: [ ]

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
        Node<T>? tempNode = Head;
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine($"List's length: {Length}");
        string? HeadString = tempNode == null ? "null" : tempNode?.Value?.ToString();
        string? TailString = Tail == null ? "null" : Tail?.Value?.ToString();
        Console.WriteLine($"Head: '{HeadString}' - Tail: '{TailString}'");
        Console.Write("List's contents: [ ");
        while (tempNode != null)
        {
            Console.Write($"{tempNode.Value} ");
            tempNode = tempNode.Next;
        }
        Console.WriteLine("]");
        Console.WriteLine("--------------------------------------------------");
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
    // 2. We have one single intem in the list.
    {
        if (Head == null) // If the list is empty:
            return null;
        else if (Length == 1)
        {
            Node<T>? tempNode = Head;
            Head = null;
            Tail = null;
            Length = 0;
            return tempNode;
        }
        else
        {
            Node<T> tempNode = Head;
            Node<T> returnNode;
            while (true)
            {
                if (tempNode.Next!.Next == null) // Forgiving null, since we know there is at least two Next valid nodes.
                {
                    Length -= 1; // Decrease the size of the list.
                    returnNode = tempNode.Next; // Save a reference to the soon-to-be-popped item.
                    tempNode.Next = null; // Setting the current node as the last one.
                    Tail = tempNode; // Moving the tail's reference to the current node.
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
