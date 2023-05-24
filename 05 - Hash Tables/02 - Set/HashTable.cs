public class HashTable
{
    public class Node
    {
        internal string? Key;
        internal int Value;
        internal Node? Next;
        public Node(string key, int value) { this.Key = key; this.Value = value; this.Next = null; }
    }
    private Node[] dataMap;
    public HashTable(int size = 7)
    {
        dataMap = new Node[size];
    }
    public void PrintTable()
    {
        for (var i = 0; i < dataMap.Length; i++)
        {
            Console.WriteLine($"Address #{i}:");
            var tempNode = dataMap[i];
            while (tempNode != null)
            {
                Console.WriteLine($"Key: {tempNode.Key} - Value: {tempNode.Value}");
                tempNode = tempNode.Next;
            }
            Console.WriteLine();
        }
    }
    private int Hash(string key)
    {
        int hash = 0;
        foreach (char character in key)
        {
            int asciiValue = (int)character;
            hash = (hash + asciiValue * 23) % dataMap.Length;
        }
        return hash;
    }
    public void Set(string key, int value)
    {
        // Figuring out the address using the Hash method:
        int address = Hash(key);
        var newNode = new Node(key, value);
        // If the address doesn't have anything, we'll assign it the new node.
        if (dataMap[address] == null)
            dataMap[address] = newNode;
        else // It means we DO have something here already
        {
            // Using a temp node to iterate through the existing nodes at the said location:
            var tempNode = dataMap[address];
            while (tempNode.Next != null)
                tempNode = tempNode.Next;
            // The temp node is the last one up to this point.
            tempNode.Next = newNode; // Appending the new node.
        }
    }
}