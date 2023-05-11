var dll = new DoublyLinkedList<int>(0);
dll.Append(1);
dll.Append(2);
dll.Append(3);
dll.Append(4);

dll.PrintList();
// --------------------------------------------------
// Length of the list: 5
// Head :'0' - Tail: '4'
// Contents: [ 0 1 2 3 4 ]
// --------------------------------------------------

var removed = dll.Remove(0);
DoublyLinkedList<int>.PrintNodeInfo(removed);
// Value: 0. Previous: null - Next: null
dll.PrintList();
// --------------------------------------------------
// Length of the list: 4
// Head :'1' - Tail: '4'
// Contents: [ 1 2 3 4 ]
// --------------------------------------------------

removed = dll.Remove(3);
DoublyLinkedList<int>.PrintNodeInfo(removed);
// Value: 4. Previous: null - Next: null
dll.PrintList();
// --------------------------------------------------
// Length of the list: 3
// Head :'1' - Tail: '3'
// Contents: [ 1 2 3 ]
// --------------------------------------------------

removed = dll.Remove(1);
DoublyLinkedList<int>.PrintNodeInfo(removed);
// Value: 2. Previous: null - Next: null
dll.PrintList();
// --------------------------------------------------
// Length of the list: 2
// Head :'1' - Tail: '3'
// Contents: [ 1 3 ]
// --------------------------------------------------

removed = dll.Remove(0);
DoublyLinkedList<int>.PrintNodeInfo(removed);
// Value: 1. Previous: null - Next: null
dll.PrintList();
// --------------------------------------------------
// Length of the list: 1
// Head :'3' - Tail: '3'
// Contents: [ 3 ]
// --------------------------------------------------

// Removing when there is only one item in the list
removed = dll.Remove(0);
DoublyLinkedList<int>.PrintNodeInfo(removed);
// Value: 3. Previous: null - Next: null
dll.PrintList();
// --------------------------------------------------
// Length of the list: 0
// Head :'null' - Tail: 'null'
// Contents: [ ]
// --------------------------------------------------

// Removing from an empty list:
removed = dll.Remove(0);
DoublyLinkedList<int>.PrintNodeInfo(removed);
// Node is null
dll.PrintList();
// --------------------------------------------------
// Length of the list: 0
// Head :'null' - Tail: 'null'
// Contents: [ ]
// --------------------------------------------------