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
    public void PrintListContents()
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
    }
}