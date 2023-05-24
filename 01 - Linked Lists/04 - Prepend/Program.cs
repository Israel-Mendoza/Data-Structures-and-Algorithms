var ll = new MyLinkedList<int>(10);

ll.PrintListItems();
// --------------------------------------------------
// List's length: 1
// Head: '10' - Tail: '10'
// List's contents: [ 10 ]
// --------------------------------------------------
ll.Prepend(20);
ll.PrintListItems();
// --------------------------------------------------
// List's length: 2
// Head: '20' - Tail: '10'
// List's contents: [ 20 10 ]
// --------------------------------------------------
ll.Prepend(30);
ll.PrintListItems();
// --------------------------------------------------
// List's length: 3
// Head: '30' - Tail: '10'
// List's contents: [ 30 20 10 ]
// --------------------------------------------------
