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
        Node? tempNode;
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
            Node? preTempNode = tempNode; // Placeholder for the Node that is to be returned.
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
        Node newNode = new Node(value);
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
}
