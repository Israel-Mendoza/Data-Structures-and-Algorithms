var dll = new DoublyLinkedList<int>(0);
dll.Append(1);
dll.Append(2);
dll.Append(3);
dll.Append(4);
dll.Append(5);

dll.PrintList();
// --------------------------------------------------
// Length of the list: 6
// Head :'0' - Tail: '5'
// Contents: [ 0 1 2 3 4 5 ]
// --------------------------------------------------

dll.Insert(3, 666);
dll.PrintList();
// --------------------------------------------------
// Length of the list: 7
// Head :'0' - Tail: '5'
// Contents: [ 0 1 2 666 3 4 5 ]
// --------------------------------------------------

dll.ClearList();

// Inserting into an empty list:
dll.Insert(0, 0);
dll.PrintList();
// --------------------------------------------------
// Length of the list: 1
// Head :'0' - Tail: '0'
// Contents: [ 0 ]
// --------------------------------------------------

dll.Insert(1, 1);
dll.PrintList();
// --------------------------------------------------
// Length of the list: 2
// Head :'0' - Tail: '1'
// Contents: [ 0 1 ]
// --------------------------------------------------
