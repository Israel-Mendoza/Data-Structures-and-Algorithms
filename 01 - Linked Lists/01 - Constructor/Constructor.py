from __future__ import annotations


class Node:
    def __init__(self: Node, value: object) -> None:
        self.value: object = value
        self.next = None


class LinkedList:
    def __init__(self: LinkedList, value: object) -> None:
        new_node: Node = Node(value)
        self.head: Node = new_node
        self.tail: Node = new_node
        self.length: int = 1

    def print_list_items(self) -> None:
        temp: Node | None = self.head
        while temp:
            print(temp.value)
            temp = temp.next


my_ll = LinkedList(4)

# Printing the value of the head
print(my_ll.head.value)

my_ll.print_list_items()
