public class BinaryTree<T>
{
    public class Node
    {
        // The Node needs a value and pointers to Left and Right.
        public T Value { get; set; }
        public Node? Left { get; set; }
        public Node? Right { get; set; }
        public Node(T value) { this.Value = value; Left = null; Right = null; }
    }
    // A Binary Tree needs a "root".
    public Node? Root { get; private set; }
    public BinaryTree()
    {
        // We won't create an initial Node. The root will be 'null'.
        this.Root = null;
    }
}