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
        Length++; // The length is increasing too.
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
            Length--; // Making the list empty.
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
            Length--;
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
        Length++;
        return true;
    }

    public Node? PopFirst()
    {
        // Edge cases: the list is empty or has one single item.
        if (Length == 0)
            return null;
        Node? poppedItem = Head;
        if (Length == 1)
        {
            Head = null;
            Tail = null;
        }
        else
            Head = Head!.Next;
        poppedItem!.Next = null;
        Length--;
        return poppedItem;
    }

    public Node? Get(int index)
    {
        if (index >= Length || index < 0)
            return null;
        Node? tempNode = Head;
        for (var i = 0; i < index; i++)
        {
            tempNode = tempNode!.Next;
        }
        return tempNode;
    }
    public bool Set(int index, T value)
    {
        Node? tempNode = this.Get(index);
        if (tempNode == null)
            return false;
        tempNode.Value = value;
        return true;
    }
    public bool Insert(int index, T value)
    {
        // Edge cases: 
        // - index is 0, then "Prepend".
        // - index is the length of the list, then "Append"
        // If none of the scenarios above fits, then we'll grab the previous
        // node to the index in question, we'll have the new node point to this
        // previous node's next, and then point the previous node to the new one.
        if (index > Length || index < 0)
            return false;
        if (index == 0)
            return Prepend(value);
        if (index == Length)
            return Append(value);
        Node? newNode = new Node(value);
        var previousNode = Get(index - 1);
        newNode.Next = previousNode!.Next;
        previousNode.Next = newNode;
        Length++;
        return true;
    }
    public Node? Remove(int index)
    {
        if (index >= Length || index < 0)
            return null;
        if (index == Length - 1)
            return Pop();
        if (index == 0)
            return PopFirst();
        var previousNode = Get(index - 1);
        var toBeRemoved = previousNode!.Next;
        previousNode.Next = toBeRemoved!.Next;
        toBeRemoved.Next = null;
        Length--;
        return toBeRemoved;
    }

    public void Revert()
    {
        // Switching the Head and the tail:
        var center = Head;
        Head = Tail;
        Tail = center;
        // if (Length > 1)
        // {
        //     // Setting the initial status of my three temp variables:
        //     Node<T>? left = null;
        //     Node<T>? right = center!.Next;
        //     while (center != null)
        //     {
        //         center.Next = left;
        //         left = center;
        //         center = right;
        //         right = center?.Next;
        //     }
        // }

        // Setting the initial status of my three temp variables:
        Node? left = null;
        Node? right = center?.Next;
        while (center != null)
        {
            center.Next = left;
            left = center;
            center = right;
            right = center?.Next;
        }
    }
}

