﻿var dll = new DoublyLinkedList<int>(0);
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

dll.Set(3, 3000);
dll.PrintList();
// --------------------------------------------------
// Length of the list: 6
// Head :'0' - Tail: '5'
// Contents: [ 0 1 2 3000 4 5 ]
// --------------------------------------------------

dll.Set(5, 5000);
dll.PrintList();
// --------------------------------------------------
// Length of the list: 6
// Head :'0' - Tail: '5000'
// Contents: [ 0 1 2 3000 4 5000 ]
// --------------------------------------------------

dll.Set(10, 1000000);
dll.PrintList();
// --------------------------------------------------
// Length of the list: 6
// Head :'0' - Tail: '5000'
// Contents: [ 0 1 2 3000 4 5000 ]
// --------------------------------------------------