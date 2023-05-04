using static System.Console;

var myLL = new MyLinkedList<int>(4);

// Printing the value of the first item in the linked list:
WriteLine(myLL.Head.Value);
myLL.PrintListItems();


class Node<T>
{
    public T Value;
    public Node<T>? Next;
    public Node(T value) { this.Value = value; this.Next = null; }
}

class MyLinkedList<T>
{
    public Node<T> Head;
    public Node<T> Tail;
    public int Length;
    public MyLinkedList(T value)
    {
        Node<T> newNode = new Node<T>(value);
        this.Head = newNode;
        this.Tail = newNode;
        this.Length = 1;
    }
    public void PrintListItems()
    {
        Node<T>? tempNode = Head;
        while (tempNode != null)
        {
            Console.WriteLine(tempNode.Value);
            tempNode = tempNode.Next;
        }
    }
}
