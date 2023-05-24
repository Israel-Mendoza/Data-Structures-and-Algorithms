var ll = new MyLinkedList<int>(10);

ll.Append(20);
ll.Append(30);
ll.Append(40);
ll.Append(50);

ll.PrintListItems();
// --------------------------------------------------
// List's length: 5
// Head: '10' - Tail: '50'
// List's contents: [ 10 20 30 40 50 ]
// --------------------------------------------------

var poppedItem = ll.PopFirst();
Console.WriteLine(poppedItem?.Value); // 10
ll.PrintListItems();
// --------------------------------------------------
// List's length: 4
// Head: '20' - Tail: '50'
// List's contents: [ 20 30 40 50 ]
// --------------------------------------------------

poppedItem = ll.PopFirst();
Console.WriteLine(poppedItem?.Value); // 20
ll.PrintListItems();
// --------------------------------------------------
// List's length: 3
// Head: '30' - Tail: '50'
// List's contents: [ 30 40 50 ]
// --------------------------------------------------

poppedItem = ll.PopFirst();
Console.WriteLine(poppedItem?.Value); // 30
ll.PrintListItems();
// --------------------------------------------------
// List's length: 2
// Head: '40' - Tail: '50'
// List's contents: [ 40 50 ]
// --------------------------------------------------

poppedItem = ll.PopFirst();
Console.WriteLine(poppedItem?.Value); // 40
ll.PrintListItems();
// --------------------------------------------------
// List's length: 1
// Head: '50' - Tail: '50'
// List's contents: [ 50 ]
// --------------------------------------------------

poppedItem = ll.PopFirst();
Console.WriteLine(poppedItem?.Value); // 50
ll.PrintListItems();
// --------------------------------------------------
// List's length: 0
// Head: 'null' - Tail: 'null'
// List's contents: [ ]
// --------------------------------------------------

poppedItem = ll.PopFirst();
Console.WriteLine(poppedItem?.Value); // 
ll.PrintListItems();
// --------------------------------------------------
// List's length: 0
// Head: 'null' - Tail: 'null'
// List's contents: [ ]
// --------------------------------------------------

