var dll = new DoublyLinkedList<int>(0);
dll.PrintList();
// --------------------------------------------------
// Length of the list: 1
// Head :'0' - Tail: '0'
// Contents: [ 0 ]
// --------------------------------------------------

dll.Prepend(666);
dll.PrintList();
// --------------------------------------------------
// Length of the list: 2
// Head :'666' - Tail: '0'
// Contents: [ 666 0 ]
// --------------------------------------------------

// Clearing the list:
dll.ClearList();
dll.PrintList();
// --------------------------------------------------
// Length of the list: 0
// Head :'null' - Tail: 'null'
// Contents: [ ]
// --------------------------------------------------

// Prepending to an empty list:
dll.Prepend(123);
dll.PrintList();
// --------------------------------------------------
// Length of the list: 1
// Head :'123' - Tail: '123'
// Contents: [ 123 ]
// --------------------------------------------------