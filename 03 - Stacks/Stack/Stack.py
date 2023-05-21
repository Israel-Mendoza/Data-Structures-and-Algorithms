from __future__ import annotations
from typing import Any


class Node:
    def __init__(self: Node, value: Any):
        self.value: Any = value
        self._next: Node | None = None

    @property
    def value(self: Node) -> Any:  # type: ignore (a property will be masking and masked)
        return self._value

    @value.setter
    def value(self: Node, value: Any) -> None:  # type: ignore (a property will be masking and masked)
        self._value = value

    @property
    def next(self: Node) -> Node | None:
        return self._next

    @next.setter
    def next(self: Node, value: Node | None) -> None:
        self._next = value


class Stack:
    def __init__(self: Stack, initial_value: Any) -> None:
        initial_node: Node | None = Node(initial_value)
        self._top: Node | None = initial_node
        self._height: int = 1

    @property
    def top(self: Stack) -> Node | None:
        return self._top

    @property
    def height(self: Stack) -> int:
        return self._height

    def print_stack(self: Stack) -> None:
        print("*" * 50)
        print(f"Height: {self.height}\nTop: {self.top.value if self.top else 'None'}")
        print("Contents: [ ", end="")
        temp_node: Node | None = self.top
        while temp_node:
            print(f"{temp_node.value} => ", end="")
            temp_node = temp_node.next
        print("None ]")
        print("*" * 50, end="\n\n")

    @staticmethod
    def print_node_info(node: Node | None):
        print("*" * 50)
        if node:
            print(f"Value: '{node.value}'")
            print(f"Next: '{node.next}'")
        else:
            print("Node is None")
        print("*" * 50)

    def push(self: Stack, new_value: Any) -> bool:
        new_node: Node | None = Node(new_value)
        if self.height:
            new_node.next = self.top
            self._top = new_node
        else:
            self._top = new_node
        self._height += 1
        return True

    def pop(self: Stack) -> Node | None:
        if self.height:
            temp_node: Node | None = self.top
            self._top = self.top.next  # type: ignore
            temp_node.next = None  # type: ignore
            self._height -= 1
            return temp_node


my_stack: Stack = Stack(0)
my_stack.push(1)
my_stack.push(2)
my_stack.push(3)

my_stack.print_stack()
# **************************************************
# Height: 4
# Top: 3
# Contents: [ 3 => 2 => 1 => 0 => None ]
# **************************************************

popped: Node | None = my_stack.pop()
Stack.print_node_info(popped)
# **************************************************
# Value: '3'
# Next: 'None'
# **************************************************

# Leaving just one item in the stack:
my_stack.pop()
my_stack.pop()
my_stack.print_stack()
# **************************************************
# Height: 1
# Top: 0
# Contents: [ 0 => None ]
# **************************************************

# Popping last item:
popped = my_stack.pop()
Stack.print_node_info(popped)
# **************************************************
# Value: '0'
# Next: 'None'
# **************************************************
my_stack.print_stack()
# **************************************************
# Height: 0
# Top: None
# Contents: [ None ]
# **************************************************

# Popping from an empty stack:
popped = my_stack.pop()
Stack.print_node_info(popped)
# **************************************************
# Node is None
# **************************************************
my_stack.print_stack()
# **************************************************
# Height: 0
# Top: None
# Contents: [ None ]
# **************************************************
