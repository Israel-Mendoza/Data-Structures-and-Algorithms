class DoublyLinkedList<T>
{
    public class Node
    {
        public T Value { get; set; }
        public Node? Next;
        public Node? Previous;
        public Node(T value) { this.Value = value; this.Next = null; this.Previous = null; }
    }
    public Node? Head { get; private set; }
    public Node? Tail { get; private set; }
    public int Length { get; private set; }
    public DoublyLinkedList(T initialValue)
    {
        Node? newNode = new Node(initialValue);
        Head = newNode;
        Tail = newNode;
        Length = 1;
    }
    public void PrintList()
    {
        var headerAndTrailer = new string('-', 50);
        Console.WriteLine(headerAndTrailer);
        Console.WriteLine($"Length of the list: {Length}");
        var headDescription = Head == null ? "null" : Head.Value!.ToString();
        var tailDescription = Tail == null ? "null" : Tail.Value!.ToString();
        Console.WriteLine($"Head :'{headDescription}' - Tail: '{tailDescription}'");
        Console.Write("Contents: [ ");
        var tempNode = Head;
        while (tempNode != null)
        {
            Console.Write($"{tempNode.Value} ");
            tempNode = tempNode.Next;
        }
        Console.WriteLine("]");
        Console.WriteLine(headerAndTrailer);
        Console.WriteLine();
    }
    public void PrintListInReverse()
    {
        var headerAndTrailer = new string('-', 50);
        Console.WriteLine(headerAndTrailer);
        Console.WriteLine($"Length of the list: {Length}");
        var headDescription = Head == null ? "null" : Head.Value!.ToString();
        var tailDescription = Tail == null ? "null" : Tail.Value!.ToString();
        Console.WriteLine($"Head :'{headDescription}' - Tail: '{tailDescription}'");
        Console.Write("Contents: [ ");
        var tempNode = Tail;
        while (tempNode != null)
        {
            Console.Write($"{tempNode.Value} ");
            tempNode = tempNode.Previous;
        }
        Console.WriteLine("]");
        Console.WriteLine(headerAndTrailer);
        Console.WriteLine();
    }
    public static void PrintNodeInfo(Node? node)
    {
        if (node == null)
            Console.WriteLine("Node is null");
        else
        {
            var prevString = node.Previous == null ? "null" : node!.Previous!.Value!.ToString();
            var nextString = node.Next == null ? "null" : node!.Next!.Value!.ToString();
            Console.WriteLine($"Value: {node.Value}. Previous: {prevString} - Next: {nextString}");
        }
    }
    public bool ClearList()
    {
        Head = null;
        Tail = null;
        Length = 0;
        return true;
    }
    public bool Append(T value)
    {
        var newNode = new Node(value);
        if (Length == 0)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Tail!.Next = newNode; // Forgiving because Tail is not null (length is not zero).
            newNode.Previous = Tail;
            Tail = newNode;
        }
        Length++;
        return true;
    }
    public Node? Pop()
    {
        if (Length == 0)
            return null;
        var tempNode = Tail; // Tail is a Node
        if (Length == 1)
        {
            Head = null;
            Tail = null;
        }
        else
        {
            Tail = Tail!.Previous; // Forgiving, because we're sure Tail is not null.
            Tail!.Next = null; // Because there was an item before Tail, Tail keeps being a Node
            tempNode!.Previous = null; // We're sure tempNode is a Node.

        }
        Length--;
        return tempNode;
    }
    public bool Prepend(T value)
    {
        var newNode = new Node(value);
        if (Length == 0)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            newNode.Next = Head;
            Head!.Previous = newNode; // Head is pointing to a Node
            Head = newNode;
        }
        Length++;
        return true;
    }
    public Node? PopFirst()
    {
        if (Length == 0)
            return null;
        var tempNode = Head;
        if (Length == 1)
        {
            Head = null;
            Tail = null;
        }
        else
        {
            Head = Head!.Next; // We've tested that at least head is a Node pointing to another node.
            Head!.Previous = null;
            tempNode!.Next = null;
        }
        Length--;
        return tempNode;
    }
    public Node? Get(int index)
    {
        if (index < 0 || index >= Length)
            return null;
        Node? tempNode;
        if (index < Length / 2) // Looking forward
        {
            tempNode = Head;
            for (var i = 0; i < index; i++)
            {
                tempNode = tempNode!.Next;
            }
        }
        else
        {
            tempNode = Tail;
            for (var i = Length - 1; i > index; i--) // Looking backwards
            {
                tempNode = tempNode!.Previous;
            }
        }
        return tempNode;
    }
    public bool Set(int index, T value)
    {
        Node? tempNode = Get(index);
        if (tempNode == null)
            return false;
        tempNode.Value = value;
        return true;
    }
    public bool Insert(int index, T value)
    {
        if (index == Length)
            return Append(value);
        if (index == 0)
            return Prepend(value);
        if (index < 0 || index > Length)
            return false;
        var newNode = new Node(value);
        var prevNode = Get(index - 1);
        newNode.Next = prevNode!.Next;
        newNode.Previous = prevNode;
        newNode.Next!.Previous = newNode;
        newNode.Previous.Next = newNode;
        Length++;
        return true;
    }
    public Node? Remove(int index)
    {
        if (index < 0 || index >= Length)
            return null;
        if (index == 0)
            return PopFirst();
        if (index == Length - 1)
            return Pop();
        var tempNode = Get(index);
        tempNode!.Next!.Previous = tempNode.Previous;
        tempNode.Previous!.Next = tempNode.Next;
        tempNode.Next = null;
        tempNode.Previous = null;
        Length--;
        return tempNode;
    }
}

