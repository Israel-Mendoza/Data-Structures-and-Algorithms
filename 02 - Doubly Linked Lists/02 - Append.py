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
            temp_node = temp_node.next
        print("]")
        print("-" * 50, end="\n\n")

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


dll: DoublyLinkedList = DoublyLinkedList(0)
dll.append(1)
dll.append(2)
dll.append(3)

dll.print_list()
# --------------------------------------------------
# Length of the list: 4
# Head: '0 - Tail: 3'
# Contents: [ 0 1 2 3 ]
# --------------------------------------------------

dll.print_list_in_reverse()
# --------------------------------------------------
# Length of the list: 4
# Head: '0 - Tail: 3'
# Contents: [ 3 ]
# --------------------------------------------------
