class MyLinkedList<T>
{
    public class Node
    {
        public T Value;
        public Node? Next;
        public Node(T value) { this.Value = value; this.Next = null; }
    }
    public Node? Head;
    public Node? Tail;
    public int Length;
    public MyLinkedList(T value)
    {
        Node? newNode = new Node(value);
        Head = newNode;
        Tail = newNode;
        Length = 1;
    }
    public void PrintListItems()
    {
        Node? tempNode = Head; // Creating a temp node to hold each node.
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
        var newNode = new Node(value);
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
    public Node? Pop()
    // Two edge cases:
    // 1. We have an empty list.
    // 2. We have one single item in the list.
    {
        if (Head == null) // If the list is empty:
            return null;
        else if (Length == 1) // If we have one single item in the list:
        {
            Node? tempNode = Head; // Keeping a copy of the tail.
            Head = null; // Making the list empty.
            Tail = null; // Making the list empty.
            Length = 0; // Making the list empty.
            return tempNode;
        }
        else // If we have more than one item in the list:
        {
            Node tempNode = Head; // Creating a temporary node to hold the iteration.
            Node returnNode; // Placeholder for the Node that is to be returned.
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
