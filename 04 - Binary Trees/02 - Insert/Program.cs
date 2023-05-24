var bt = new BinaryTree();


bt.Insert(47);
bt.Insert(21);
bt.Insert(76);
bt.Insert(18);
bt.Insert(27);
bt.Insert(52);
bt.Insert(82);
bt.Insert(15);
bt.Insert(19);
bt.Insert(25);
bt.Insert(30);
bt.Insert(49);
bt.Insert(59);
bt.Insert(77);
bt.Insert(90);

// Printing 25
Console.WriteLine(bt.Root!.Left!.Right!.Left!.Value);
// 25

// MY TREE:
//                      47
//           21                        76
//     18          27            52          82
//  15    19    25    30      49    59    77    90