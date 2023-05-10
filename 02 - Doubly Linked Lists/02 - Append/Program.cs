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
dll.PrintListInReverse();
// --------------------------------------------------
// Length of the list: 4
// Head :'0' - Tail: '3'
// Contents: [ 3 2 1 0 ]
// --------------------------------------------------