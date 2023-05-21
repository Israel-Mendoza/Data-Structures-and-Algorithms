public class MyQueue<T>
{
    public class Node
    {
        public T Value { get; set; }
        public Node? Next;
        public Node(T Value) { this.Value = Value; this.Next = null; }
    }
    public Node? First { get; private set; }
    public Node? Last { get; private set; }
    public int Length { get; private set; }
    public MyQueue(T initialValue)
    {
        var newNode = new Node(initialValue);
        First = newNode;
        Last = newNode;
        Length = 1;
    }
    public void PrintQueue()
    {
        var header = new string('*', 50);
        var firstDescription = First == null ? "null" : First.Value!.ToString();
        var lastDescription = Last == null ? "null" : Last.Value!.ToString();
        Console.WriteLine(header);
        Console.WriteLine($"Length: {Length}\nFirst: {firstDescription}\nLast: {lastDescription}");
        Console.Write("Contents [ ");
        var temporaryNode = First;
        while (temporaryNode != null)
        {
            Console.Write($"{temporaryNode.Value!.ToString()} => ");
            temporaryNode = temporaryNode.Next;
        }
        Console.WriteLine("null ]");
        Console.WriteLine(header + "\n");
    }
    public static void PrintNodeInfo(Node? node)
    {
        var header = new string('*', 50);
        Console.WriteLine(header);
        if (node == null)
            Console.WriteLine("Node is null.");
        else
        {
            Console.WriteLine($"Value: '{node.Value!.ToString()}'");
            Console.WriteLine($"Next: '{node.Next}'");
        }
        Console.WriteLine(header);
    }
    public bool Enqueue(T newValue)
    {
        var newNode = new Node(newValue);
        if (Length == 0)
        {
            First = newNode;
            Last = newNode;
        }
        else
        {
            Last!.Next = newNode;
            Last = newNode;
        }
        Length++;
        return true;
    }
    public Node? Dequeue()
    {
        if (Length == 0)
            return null;
        var temporaryNode = First;
        if (Length == 1)
        {
            First = null;
            Last = null;
        }
        else
            First = First!.Next;
        temporaryNode!.Next = null;
        Length--;
        return temporaryNode;
    }
}