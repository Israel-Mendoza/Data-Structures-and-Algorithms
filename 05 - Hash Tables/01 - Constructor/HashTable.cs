public class HashTable
{
    public class Node
    {
        internal string? key;
        internal int value;
        internal Node? next;
        public Node(string key, int value) { this.key = key; this.value = value; this.next = null; }
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
            Console.WriteLine($"{i}:");
            var tempNode = dataMap[i];
            while (tempNode != null)
            {
                Console.WriteLine($"Key: {tempNode.key} - Value: {tempNode.value}");
                tempNode = tempNode.next;
            }
        }
    }
    private int hash(string key)
    {
        int hash = 0;
        foreach (char character in key)
        {
            int asciiValue = (int)character;
            hash = (hash + asciiValue * 23) % dataMap.Length;
        }
        return hash;
    }
}