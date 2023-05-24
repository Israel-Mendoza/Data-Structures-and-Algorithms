public class BinaryTree
{
    public class Node
    {
        // The Node needs a value and pointers to Left and Right.
        public int Value { get; set; }
        public Node? Left { get; set; }
        public Node? Right { get; set; }
        public Node(int value) { this.Value = value; Left = null; Right = null; }
    }
    // A Binary Tree needs a "root".
    public Node? Root { get; private set; }
    public BinaryTree()
    {
        // We won't create an initial Node. The root will be 'null'.
        this.Root = null;
    }
    public bool Insert(int newValue)
    {
        // Edge cases: 
        // Tree is empty and the value already exists. 
        // We'll user a temp node to navigate through the tree.
        var newNode = new Node(newValue);
        if (Root == null)
        {
            Root = newNode;
            return true;
        }
        var tempNode = Root; // Temporary node to navigate through the tree
        while (true)
        {
            if (newNode.Value == tempNode.Value) // If the "new value" already exists.
                return false;
            if (newNode.Value > tempNode.Value)
            {
                if (tempNode.Right == null)
                {
                    tempNode.Right = newNode;
                    return true;
                }
                tempNode = tempNode.Right;
            }
            else
            {
                if (tempNode.Left == null)
                {
                    tempNode.Left = newNode;
                    return true;
                }
                tempNode = tempNode.Left;
            }
        }
    }
    public bool Contains(int value)
    {
        var tempNode = Root;
        while (tempNode != null) // If the tempNode is null, it won't access the loop
        {
            if (value == tempNode.Value)
                return true;
            if (value > tempNode.Value)
                tempNode = tempNode.Right;
            else
                tempNode = tempNode.Left;
        }
        return false;
    }
}