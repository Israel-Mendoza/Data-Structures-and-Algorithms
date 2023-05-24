var ll = new MyLinkedList<int>(0);

ll.Append(1);
ll.Append(2);
ll.Append(3);

ll.PrintListItems();
// --------------------------------------------------
// List's length: 4
// Head: '0' - Tail: '3'
// List's contents: [ 0 1 2 3 ]
// --------------------------------------------------

ll.Revert();
ll.PrintListItems();
// --------------------------------------------------
// List's length: 4
// Head: '3' - Tail: '0'
// List's contents: [ 3 2 1 0 ]
// --------------------------------------------------

// Getting a list with only 2 items:
ll.Pop(); ll.Pop();
ll.PrintListItems();
// --------------------------------------------------
// List's length: 2
// Head: '3' - Tail: '2'
// List's contents: [ 3 2 ]
// --------------------------------------------------

// Reverting it:
ll.Revert();
ll.PrintListItems();
// --------------------------------------------------
// List's length: 2
// Head: '2' - Tail: '3'
// List's contents: [ 2 3 ]
// --------------------------------------------------

// Getting a list with one single item:
ll.Pop();
ll.PrintListItems();
// --------------------------------------------------
// List's length: 1
// Head: '2' - Tail: '2'
// List's contents: [ 2 ]
// --------------------------------------------------

// Reverting it:
ll.Revert();
ll.PrintListItems();
// --------------------------------------------------
// List's length: 1
// Head: '2' - Tail: '2'
// List's contents: [ 2 ]
// --------------------------------------------------

// Getting an empty list:
ll.Pop();
ll.PrintListItems();
// --------------------------------------------------
// List's length: 0
// Head: 'null' - Tail: 'null'
// List's contents: [ ]
// --------------------------------------------------

// Reverting it:
ll.Revert();
ll.PrintListItems();
// --------------------------------------------------
// List's length: 0
// Head: 'null' - Tail: 'null'
// List's contents: [ ]
// --------------------------------------------------
