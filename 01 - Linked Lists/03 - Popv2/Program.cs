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

var temp = ll.Pop();
Console.WriteLine(temp?.Value); // 50
ll.PrintListItems();
// --------------------------------------------------
// List's length: 4
// Head: '10' - Tail: '40'
// List's contents: [ 10 20 30 40 ]
// --------------------------------------------------

temp = ll.Pop();
Console.WriteLine(temp?.Value); // 40
ll.PrintListItems();
// --------------------------------------------------
// List's length: 3
// Head: '10' - Tail: '30'
// List's contents: [ 10 20 30 ]
// --------------------------------------------------

temp = ll.Pop();
Console.WriteLine(temp?.Value); // 30
ll.PrintListItems();
// --------------------------------------------------
// List's length: 2
// Head: '10' - Tail: '20'
// List's contents: [ 10 20 ]
// --------------------------------------------------

temp = ll.Pop();
Console.WriteLine(temp?.Value); // 20
ll.PrintListItems();
// --------------------------------------------------
// List's length: 1
// Head: '10' - Tail: '10'
// List's contents: [ 10 ]
// --------------------------------------------------

temp = ll.Pop();
Console.WriteLine(temp?.Value); // 10
ll.PrintListItems();
// --------------------------------------------------
// List's length: 0
// Head: 'null' - Tail: 'null'
// List's contents: [ ]
// --------------------------------------------------

temp = ll.Pop();
Console.WriteLine($"Popped value: '{temp?.Value}'");
// Popped value: ''
