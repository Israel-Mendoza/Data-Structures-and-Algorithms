var myStack = new MyStack<int>(0);
myStack.Push(1);
myStack.Push(2);
myStack.Push(3);

myStack.PrintStack();
// **************************************************
// Height: 4
// Top: 3
// Contents [ 3 => 2 => 1 => 0 => null ]
// **************************************************

var popped = myStack.Pop();
MyStack<int>.PrintNodeInfo(popped);
// **************************************************
// Value: '3'
// Next: ''
// **************************************************
myStack.PrintStack();
// **************************************************
// Height: 3
// Top: 2
// Contents [ 2 => 1 => 0 => null ]
// **************************************************

// Leaving just 1 item in the stack:
myStack.Pop(); myStack.Pop();
myStack.PrintStack();
// **************************************************
// Height: 1
// Top: 0
// Contents [ 0 => null ]
// **************************************************

// Popping last item:
popped = myStack.Pop();
MyStack<int>.PrintNodeInfo(popped);
// **************************************************
// Value: '0'
// Next: ''
// **************************************************
myStack.PrintStack();
// **************************************************
// Height: 0
// Top: null
// Contents [ null ]
// **************************************************

// Popping from an empty stack:
popped = myStack.Pop();
MyStack<int>.PrintNodeInfo(popped);
// **************************************************
// Node is null.
// **************************************************
myStack.PrintStack();
// **************************************************
// Height: 0
// Top: null
// Contents [ null ]
// **************************************************