var ll = new MyLinkedList<int>(0);

ll.Append(1);
ll.Append(2);
ll.Append(123456789);
ll.Append(3);

ll.PrintListItems();
// --------------------------------------------------
// List's length: 5
// Head: '0' - Tail: '3'
// List's contents: [ 0 1 2 123456789 3 ]
// --------------------------------------------------

var something = ll.Remove(3);

Console.WriteLine(something!.Value);
// 123456789

ll.PrintListItems();
// --------------------------------------------------
// List's length: 4
// Head: '0' - Tail: '3'
// List's contents: [ 0 1 2 3 ]
// --------------------------------------------------

ll.Remove(3);
ll.PrintListItems();
// --------------------------------------------------
// List's length: 3
// Head: '0' - Tail: '2'
// List's contents: [ 0 1 2 ]
// --------------------------------------------------

ll.Remove(0);
ll.PrintListItems();
// --------------------------------------------------
// List's length: 2
// Head: '1' - Tail: '2'
// List's contents: [ 1 2 ]
// --------------------------------------------------