from __future__ import annotations
from typing import Any


class Node:
    def __init__(self: Node, value: Any) -> None:
        self.value: Any = value
        self.next: Node | None = None
        self.previous: Node | None = None


class DoublyLinkedList:
    def __init__(self: DoublyLinkedList, initial_value: Any) -> None:
        new_node: Node | None = Node(initial_value)
        self._head: Node | None = new_node
        self._tail: Node | None = new_node
        self._length: int = 1

    @property
    def length(self: DoublyLinkedList) -> int:
        return self._length

    @property
    def head(self: DoublyLinkedList) -> Node | None:
        return self._head

    @property
    def tail(self: DoublyLinkedList) -> Node | None:
        return self._tail

    def print_list(self: DoublyLinkedList) -> None:
        print("-" * 50)
        print(f"Length of the list: {self.length}")
        head_description: str = "None" if self.head is None else self.head.value
        tail_description: str = "None" if self.tail is None else self.tail.value
        print(f"Head: '{head_description} - Tail: {tail_description}'")
        print(f"Contents: [ ", end="")
        temp_node: Node | None = self.head
        while temp_node:
            print(f"{temp_node.value} ", end="")
            temp_node = temp_node.next
        print("]")
        print("-" * 50, end="\n\n")

    def print_list_in_reverse(self: DoublyLinkedList) -> None:
        print("-" * 50)
        print(f"Length of the list: {self.length}")
        head_description: str = "None" if self.head is None else self.head.value
        tail_description: str = "None" if self.tail is None else self.tail.value
        print(f"Head: '{head_description} - Tail: {tail_description}'")
        print(f"Contents: [ ", end="")
        temp_node: Node | None = self.tail
        while temp_node:
            print(f"{temp_node.value} ", end="")
            temp_node = temp_node.previous
        print("]")
        print("-" * 50, end="\n\n")

    @staticmethod
    def print_node_information(node: Node | None) -> None:
        if node is None:
            print("Node is None")
        else:
            prev_string: str = "None" if node.previous is None else node.previous.value
            next_string: str = "None" if node.next is None else node.next.value
            print(f"Value: {node.value}. Previous: {prev_string} - Next: {next_string}")

    def clear_list(self: DoublyLinkedList) -> bool:
        self._head = None
        self._tail = None
        self._length = 0
        return True

    def append(self: DoublyLinkedList, value: Any) -> bool:
        new_node: Node = Node(value)
        if self.length == 0:
            self._head = new_node
            self._tail = new_node
        else:
            self._tail.next = new_node  # type: ignore // Tail is not None (length is not zero).
            new_node.previous = self.tail
            self._tail = new_node
        self._length += 1
        return True

    def pop(self: DoublyLinkedList) -> Node | None:
        if self.length == 0:
            return None
        temp_node: Node | None = self.tail
        if self.length == 1:
            self._head = None
            self._tail = None
        else:
            self._tail = self.tail.previous  # type: ignore
            self._tail.next = None  # type: ignore
            temp_node.previous = None  # type: ignore
        self._length -= 1
        return temp_node

    def prepend(self: DoublyLinkedList, value: Any) -> bool:
        new_node: Node | None = Node(value)
        if self.length == 0:
            self._head = new_node
            self._tail = new_node
        else:
            new_node.next = self.head
            self.head.previous = new_node  # type: ignore // Head IS pointing to a Node
            self._head = new_node
        self._length += 1
        return True

    def pop_first(self: DoublyLinkedList) -> Node | None:
        if self.length == 0:
            return None
        temp_node: Node | None = self.head
        if self.length == 1:
            self._head = None
            self._tail = None
        else:
            self._head = self.head.next  # type: ignore
            self._head.previous = None  # type: ignore
            temp_node.next = None  # type: ignore
        self._length -= 1
        return temp_node

    def get(self: DoublyLinkedList, index: int) -> Node | None:
        if index < 0 or index >= self.length:
            return None
        if index < self.length / 2:
            temp_node: Node | None = self.head
            for _ in range(index):
                temp_node = temp_node.next  # type: ignore (we know temp_node is a Node)
        else:
            temp_node: Node | None = self.tail
            for _ in range(self.length - 1, index, -1):
                temp_node = temp_node.previous  # type: ignore (we know temp_node is a Node)
        return temp_node


dll: DoublyLinkedList = DoublyLinkedList(0)
dll.pop()

gotten: Node | None = dll.get(0)
DoublyLinkedList.print_node_information(gotten)
# Node is None

dll.append(0)

# Getting node from a list with a single item
gotten = dll.get(0)
DoublyLinkedList.print_node_information(gotten)
# Value: 0. Previous: None - Next: None

dll.append(1)
dll.append(2)
dll.append(3)
dll.append(4)
dll.append(5)

# Getting an item from the middle of the list:
gotten = dll.get(3)
DoublyLinkedList.print_node_information(gotten)
# Value: 3. Previous: 2 - Next: 4
