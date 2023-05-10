var dll = new DoublyLinkedList<int>(0);
dll.Append(1);
dll.Append(2);
dll.Append(3);

dll.PrintList();
// --------------------------------------------------
// Length of the list: 4
// Head :'0' - Tail: '3'
// Contents: [ 0 1 2 3 ]
// --------------------------------------------------

var popped = dll.PopFirst();
DoublyLinkedList<int>.PrintNodeInfo(popped);
// Value: 0. Previous: null - Next: null

dll.PrintList();
// --------------------------------------------------
// Length of the list: 3
// Head :'1' - Tail: '3'
// Contents: [ 1 2 3 ]
// --------------------------------------------------

// Leaving the list with just one item:
dll.Pop(); dll.Pop();
dll.PrintList();
// --------------------------------------------------
// Length of the list: 1
// Head :'1' - Tail: '1'
// Contents: [ 1 ]
// --------------------------------------------------

// Popping the single item:
popped = dll.PopFirst();
DoublyLinkedList<int>.PrintNodeInfo(popped);
// Value: 1. Previous: null - Next: null
dll.PrintList();
// --------------------------------------------------
// Length of the list: 0
// Head :'null' - Tail: 'null'
// Contents: [ ]
// --------------------------------------------------

// Popping from an empty list:
popped = dll.PopFirst();
DoublyLinkedList<int>.PrintNodeInfo(popped);
// Node is null
dll.PrintList();
// --------------------------------------------------
// Length of the list: 0
// Head :'null' - Tail: 'null'
// Contents: [ ]
// --------------------------------------------------