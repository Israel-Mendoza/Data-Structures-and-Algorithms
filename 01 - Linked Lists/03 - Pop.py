from __future__ import annotations


class Node:
    def __init__(self: Node, value: object) -> None:
        self.value: object = value
        self.next: Node | None = None


class LinkedList:
    def __init__(self: LinkedList, value: object) -> None:
        new_node: Node = Node(value)
        self.head: Node | None = new_node
        self.tail: Node | None = new_node
        self.length: int = 1

    def print_list_items(self) -> None:
        temp: Node | None = self.head
        print("-" * 50)
        print(f"List's length: {self.length}")
        print(
            f"Head: '{self.head.value if self.head is not None else 'None'}' - ", end=""
        )
        print(f"Tail: '{self.tail.value if self.tail is not None else 'None'}'.")
        print("List's contents: [ ", end="")
        while temp:
            print(f"{temp.value} ", end="")
            temp = temp.next
        print("]")
        print("-" * 50)

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

    def pop(self: LinkedList) -> Node | None:
        # Edge cases:
        # 1. The list is empty.
        # 2. The list has one single item.
        if self.head is None:
            return None
        elif self.length == 1:
            temp_node = self.tail
            self.head = None
            self.tail = None
            self.length = 0
            return temp_node
        else:
            temp_node: Node | None = self.head
            return_node: Node | None
            while True:
                if temp_node.next.next is None:
                    return_node = temp_node.next  # Save the reference
                    self.length -= 1  # Decrease the length of the list
                    self.tail = temp_node  # Move the tail's reference
                    temp_node.next = None  # Make the current node the last one
                    return return_node
                else:
                    temp_node = temp_node.next


ll: LinkedList = LinkedList(10)

ll.append(20)
ll.append(30)
ll.append(40)
ll.append(50)

ll.print_list_items()
# --------------------------------------------------
# List's length: 5
# Head: '10' - Tail: '50'.
# List's contents: [ 10 20 30 40 50 ]
# --------------------------------------------------

temp: Node | None = ll.pop()
print(f"Popped node: {temp.value if temp is not None else ''}")
# Popped node: 50
ll.print_list_items()
# --------------------------------------------------
# List's length: 4
# Head: '10' - Tail: '40'.
# List's contents: [ 10 20 30 40 ]
# --------------------------------------------------

temp = ll.pop()
print(f"Popped node: {temp.value if temp is not None else ''}")
# Popped node: 40
ll.print_list_items()
# --------------------------------------------------
# List's length: 3
# Head: '10' - Tail: '30'.
# List's contents: [ 10 20 30 ]
# --------------------------------------------------

temp = ll.pop()
print(f"Popped node: {temp.value if temp is not None else ''}")
# Popped node: 30
ll.print_list_items()
# --------------------------------------------------
# List's length: 2
# Head: '10' - Tail: '20'.
# List's contents: [ 10 20 ]
# --------------------------------------------------

temp = ll.pop()
print(f"Popped node: {temp.value if temp is not None else ''}")
# Popped node: 20
ll.print_list_items()
# --------------------------------------------------
# List's length: 1
# Head: '10' - Tail: '10'.
# List's contents: [ 10 ]
# --------------------------------------------------


temp = ll.pop()
print(f"Popped node: {temp.value if temp is not None else ''}")
# Popped node: 10
ll.print_list_items()
# --------------------------------------------------
# List's length: 0
# Head: 'None' - Tail: 'None'.
# List's contents: [ ]
# --------------------------------------------------

temp = ll.pop()
print(f"Popped node: {temp.value if temp is not None else 'None'}")
# Popped node: None
ll.print_list_items()
# --------------------------------------------------
# List's length: 0
# Head: 'None' - Tail: 'None'.
# List's contents: [ ]
# --------------------------------------------------
