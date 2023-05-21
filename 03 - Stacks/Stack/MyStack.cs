public class MyStack<T>
{
    public class Node
    {
        public T Value { get; set; }
        public Node? Next;
        public Node(T value)
        {
            this.Value = value;
            this.Next = null;
        }
    }
    public Node? Top { get; private set; }
    public int Height { get; private set; }
    public MyStack(T intialValue)
    {
        var newNode = new Node(intialValue);
        Top = newNode;
        Height = 1;
    }
    public void PrintStack()
    {
        var header = new string('*', 50);
        var topDescription = Top == null ? "null" : Top.Value!.ToString();
        Console.WriteLine(header);
        Console.WriteLine($"Height: {Height}\nTop: {topDescription}");
        Console.Write("Contents [ ");
        var temporaryNode = Top;
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
    public bool Push(T newValue)
    {
        var newNode = new Node(newValue);
        if (Height == 0)
            Top = newNode;
        else
        {
            newNode.Next = Top;
            Top = newNode;
        }
        Height++;
        return true;
    }
    public Node? Pop()
    {
        if (Height == 0)
            return null;
        var temporaryNode = Top;
        Top = Top!.Next;
        temporaryNode!.Next = null;
        Height--;
        return temporaryNode;
    }
}