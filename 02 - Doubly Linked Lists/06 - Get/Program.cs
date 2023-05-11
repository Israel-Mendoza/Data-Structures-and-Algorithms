var dll = new DoublyLinkedList<int>(0);
dll.Pop();

// Get an item from an empty list:
var gotten = dll.Get(0);
DoublyLinkedList<int>.PrintNodeInfo(gotten);
// Node is null

dll.Append(0);

// Get an item from a list with just one item:
gotten = dll.Get(0);
DoublyLinkedList<int>.PrintNodeInfo(gotten);
// Value: 0. Previous: null - Next: null

dll.Append(1); dll.Append(2); dll.Append(3); dll.Append(4); dll.Append(5);

// Getting an item from the middle of the list:
gotten = dll.Get(3);
DoublyLinkedList<int>.PrintNodeInfo(gotten);
// Value: 3. Previous: 2 - Next: 4