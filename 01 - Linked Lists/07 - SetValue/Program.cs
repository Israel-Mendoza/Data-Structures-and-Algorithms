var ll = new MyLinkedList<int>(0);
ll.Append(1);
ll.Append(2);
ll.Append(3);
ll.Append(4);
ll.Append(5);

bool success;

ll.PrintListItems();
// --------------------------------------------------
// List's length: 6
// Head: '0' - Tail: '5'
// List's contents: [ 0 1 2 3 4 5 ]
// --------------------------------------------------

success = ll.Set(3, 30);

ll.PrintListItems();
// --------------------------------------------------
// List's length: 6
// Head: '0' - Tail: '5'
// List's contents: [ 0 1 2 30 4 5 ]
// --------------------------------------------------
Console.WriteLine(success); // True

success = ll.Set(10, 1000);

ll.PrintListItems();
// --------------------------------------------------
// List's length: 6
// Head: '0' - Tail: '5'
// List's contents: [ 0 1 2 30 4 5 ]
// --------------------------------------------------
Console.WriteLine(success); // False

success = ll.Set(-1, 1000);

ll.PrintListItems();
// --------------------------------------------------
// List's length: 6
// Head: '0' - Tail: '5'
// List's contents: [ 0 1 2 30 4 5 ]
// --------------------------------------------------
Console.WriteLine(success); // False
