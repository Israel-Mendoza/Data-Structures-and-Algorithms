from __future__ import annotations


class Node:
    def __init__(self: Node, value: object) -> None:
        self.value: object = value
        self.next: Node | None = None


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

    def append(self: LinkedList, value: object) -> bool:
        new_node: Node = Node(value)
        if self.head is None:  # If the LinkedList is empty:
            self.head = new_node
            self.tail = new_node
        else:
            self.tail.next = new_node  # The old "tail" needs to point to the new node
            self.tail = new_node  # The tail needs to point to the new node
        self.length += 1  # Length is increasing
        return True  # For future purposes ;)


# Creating a linked list with initial value of 1:
ll: LinkedList = LinkedList(1)

# Appending to the end of the list
ll.append(2)
ll.append(3)
ll.append(4)

# Printing the current items in the list
ll.print_list_items()
# 1
# 2
# 3
# 4
