var myQueue = new MyQueue<int>(0);
myQueue.Enqueue(1);
myQueue.Enqueue(2);
myQueue.Enqueue(3);

myQueue.PrintQueue();
// **************************************************
// Length: 4
// First: 0
// Last: 3
// Contents [ 0 => 1 => 2 => 3 => null ]
// **************************************************

var dequeued = myQueue.Dequeue();
MyQueue<int>.PrintNodeInfo(dequeued);
// **************************************************
// Value: '0'
// Next: ''
// **************************************************
myQueue.PrintQueue();
// **************************************************
// Length: 3
// First: 1
// Last: 3
// Contents [ 1 => 2 => 3 => null ]
// **************************************************

// Leaving one item in the queue:
myQueue.Dequeue(); myQueue.Dequeue();

myQueue.PrintQueue();
// **************************************************
// Length: 1
// First: 3
// Last: 3
// Contents [ 3 => null ]
// **************************************************

// Dequeueing the last item:
dequeued = myQueue.Dequeue();
MyQueue<int>.PrintNodeInfo(dequeued);
// **************************************************
// Value: '3'
// Next: ''
// **************************************************
myQueue.PrintQueue();
// **************************************************
// Length: 0
// First: null
// Last: null
// Contents [ null ]
// **************************************************

// Dequeueing from an empty queue:
dequeued = myQueue.Dequeue();
MyQueue<int>.PrintNodeInfo(dequeued);
// **************************************************
// Node is null.
// **************************************************
