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

var popped = dll.Pop();
DoublyLinkedList<int>.PrintNodeInfo(popped);
// Value: 3. Previous: null - Next: null

dll.PrintList();
// --------------------------------------------------
// Length of the list: 3
// Head :'0' - Tail: '2'
// Contents: [ 0 1 2 ]
// --------------------------------------------------

// Popping two more, so we can leave the list with one item:
dll.Pop();
dll.Pop();
dll.PrintList();
// --------------------------------------------------
// Length of the list: 1
// Head :'0' - Tail: '0'
// Contents: [ 0 ]
// --------------------------------------------------

popped = dll.Pop();
DoublyLinkedList<int>.PrintNodeInfo(popped);
// Value: 0. Previous: null - Next: null

dll.PrintList();
// --------------------------------------------------
// Length of the list: 0
// Head :'null' - Tail: 'null'
// Contents: [ ]
// --------------------------------------------------

// Popping from an empty list?
popped = dll.Pop();
DoublyLinkedList<int>.PrintNodeInfo(popped);
// Node is null

dll.PrintList();
// --------------------------------------------------
// Length of the list: 0
// Head :'null' - Tail: 'null'
// Contents: [ ]
// --------------------------------------------------