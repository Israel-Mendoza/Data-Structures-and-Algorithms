// Creating a linked list with value of 1:
var myLL = new MyLinkedList<int>(1);

// Appending to the end of the list
myLL.Append(2);
myLL.Append(3);
myLL.Append(4);

// Printing the current items in the list
myLL.PrintListItems();
// 1
// 2
// 3
// 4


//////////////////////////////CLASSES//////////////////////////////


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
        Head = newNode;
        Tail = newNode;
        Length = 1;
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
    public bool Append(T value)
    {
        var newNode = new Node<T>(value);
        if (Head == null) // If the list is empty:
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Tail.Next = newNode; // The old tail needs to point to the new node.
            Tail = newNode; // The tail needs to point to the new node.
        }
        Length += 1; // The length is increasing too.
        return true; // For future purposes ;)
    }
}
