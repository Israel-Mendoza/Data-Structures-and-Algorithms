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
        this.Head = newNode;
        this.Tail = newNode;
        this.Length = 1;
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
}
