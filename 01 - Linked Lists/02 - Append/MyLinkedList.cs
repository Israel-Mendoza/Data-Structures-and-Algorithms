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
        Node newNode = new Node(value);
        Head = newNode;
        Tail = newNode;
        Length = 1;
    }
    public void PrintListItems()
    {
        Node? tempNode = Head;
        while (tempNode != null)
        {
            Console.WriteLine(tempNode.Value);
            tempNode = tempNode.Next;
        }
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
}
