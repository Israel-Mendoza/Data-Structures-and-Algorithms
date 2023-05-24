var ll = new MyLinkedList<int>(5);
ll.Append(15);
ll.Append(25);
ll.Append(35);
ll.Append(45);
ll.Append(55);

ll.PrintListItems();
// --------------------------------------------------
// List's length: 6
// Head: '5' - Tail: '55'
// List's contents: [ 5 15 25 35 45 55 ]
// --------------------------------------------------

var item = ll.Get(2);
Console.WriteLine(item?.Value); // 25

item = ll.Get(10);
Console.WriteLine(item?.Value); // 

item = ll.Get(-2);
Console.WriteLine(item?.Value); // 
