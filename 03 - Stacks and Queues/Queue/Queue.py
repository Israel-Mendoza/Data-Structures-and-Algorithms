from __future__ import annotations
from typing import Any


class Node:
    def __init__(self: Node, value: Any):
        self.value: Any = value
        self.next: Node | None = None

    @property
    def value(self: Node) -> Any:  # type: ignore (a property will be masking and masked)
        return self._value

    @value.setter
    def value(self: Node, value: Any) -> None:  # type: ignore (a property will be masking and masked)
        self._value = value

    @property
    def next(self: Node) -> Node | None:  # type: ignore (a property will be masking and masked)
        return self._next

    @next.setter
    def next(self: Node, value: Node | None) -> None:  # type: ignore (a property will be masking and masked)
        self._next = value


class Queue:
    def __init__(self: Queue, initial_value: Any) -> None:
        initial_node: Node | None = Node(initial_value)
        self._first: Node | None = initial_node
        self._last: Node | None = initial_node
        self._length: int = 1

    @property
    def first(self: Queue) -> Node | None:
        return self._first

    @property
    def last(self: Queue) -> Node | None:
        return self._last

    @property
    def length(self: Queue) -> int:
        return self._length

    def print_queue(self: Queue) -> None:
        print("*" * 50)
        print(
            f"Length: {self.length} \n"
            + f"First: {self.first.value if self.first else 'None'} \n"
            + f"Last: {self.last.value if self.last else 'None'}"
        )
        print("Contents: [ ", end="")
        temp_node: Node | None = self.first
        while temp_node:
            print(f"{temp_node.value} => ", end="")
            temp_node = temp_node.next
        print("None ]")
        print("*" * 50, end="\n\n")

    @staticmethod
    def print_node_info(node: Node | None) -> None:
        print("*" * 50)
        if node:
            print(f"Value: '{node.value}'")
            print(f"Next: '{node.next}'")
        else:
            print("Node is None")
        print("*" * 50)

    def enqueue(self: Queue, new_value: Any) -> bool:
        new_node: Node | None = Node(new_value)
        if self.length:
            self.last.next = new_node  # type: ignore (self.last IS a node)
            self._last = new_node
        else:
            self._first = new_node
            self._last = new_node
        self._length += 1
        return True

    def dequeue(self: Queue) -> Node | None:
        if self.length == 0:
            return None
        temp_node: Node | None = self.first
        if self.length == 1:
            self._first = None
            self._last = None
        else:
            self._first = self.first.next  # type: ignore (self.first IS a node)
        temp_node.next = None  # type: ignore (temp_node IS a node)
        self._length -= 1
        return temp_node


my_queue: Queue = Queue(0)
my_queue.enqueue(1)
my_queue.enqueue(2)
my_queue.enqueue(3)

my_queue.print_queue()
# **************************************************
# Length: 4
# First: 0
# Last: 3
# Contents: [ 0 => 1 => 2 => 3 => None ]
# **************************************************

dequeued: Node | None = my_queue.dequeue()
Queue.print_node_info(dequeued)
# **************************************************
# Value: '0'
# Next: 'None'
# **************************************************

my_queue.print_queue()
# **************************************************
# Length: 3
# First: 1
# Last: 3
# Contents: [ 1 => 2 => 3 => None ]
# **************************************************

# Leaving just one item in the queue
my_queue.dequeue()
my_queue.dequeue()

my_queue.print_queue()
# **************************************************
# Length: 1
# First: 3
# Last: 3
# Contents: [ 3 => None ]
# **************************************************

# Dequeueing the last item
dequeued = my_queue.dequeue()
Queue.print_node_info(dequeued)
# **************************************************
# Value: '3'
# Next: 'None'
# **************************************************

my_queue.print_queue()
# **************************************************
# Length: 0
# First: None
# Last: None
# Contents: [ None ]
# **************************************************

# Dequeueing from an empty queue
dequeued = my_queue.dequeue()
Queue.print_node_info(dequeued)
# **************************************************
# Node is None
# **************************************************
my_queue.print_queue()
# **************************************************
# Length: 0
# First: None
# Last: None
# Contents: [ None ]
# **************************************************
