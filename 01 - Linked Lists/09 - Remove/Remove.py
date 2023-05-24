from __future__ import annotations


# CLASSES


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
        temp: Node | None = self.head  # Creating a temp node to hold each node.
        print("-" * 50)
        print(f"List's length: {self.length}")
        print(
            f"Head: '{self.head.value if self.head is not None else 'None'}' - ", end=""
        )
        print(f"Tail: '{self.tail.value if self.tail is not None else 'None'}'.")
        print("List's contents: [ ", end="")
        while temp:  # As long as we don't reach a "dead" node.
            print(f"{temp.value} ", end="")
            temp = temp.next
        print("]")
        print("-" * 50)

    def append(self: LinkedList, value: object) -> bool:
        # Edge case:
        # 1. The list is empty.
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
        # If there is more than one item in the list, we'll proceed to create two
        # Node variables that will iterate over the list.
        # The first one (temp_node) will be testing whether the Node's "next"
        # attribute is pointing to "None". When it does, we will have found
        # the Node to be popped. We'll return this value.
        # The second Node (pre_temp_node) will point to the previous Node
        # that points to temp_node, so we can use it as the new tail.
        if self.length == 0:  # If the list is empty:
            return None
        # We'll be populating a variable called "temp_node" with a node:
        if self.length == 1:  #  If we have one single item in the list:
            temp_node = self.tail  # Keeping a copy of the tail.
            self.head = None  # Making the list empty.
            self.tail = None  # Making the list empty.
            self.length -= 1  # Making the list empty.
        else:
            temp_node: Node | None = self.head
            pre_temp_node: Node | None = self.head
            while temp_node.next:
                pre_temp_node = temp_node
                temp_node = temp_node.next
            # After the loop breaks, we will have found
            # the last and new tail of the list.
            self.tail = pre_temp_node
            self.tail.next = None
            self.length -= 1
        return temp_node

    def prepend(self: LinkedList, value: object) -> bool:
        # Edge case: the list is empty
        new_node: Node = Node(value)
        if self.length == 0:
            self.head = new_node
            self.tail = new_node
        else:
            new_node.next = self.head
            self.head = new_node
        self.length += 1
        return True

    def pop_first(self: LinkedList) -> Node | None:
        # Edge cases: the list is empty or has one single item.
        if self.length == 0:
            return None
        popped_node: Node | None = self.head
        if self.length == 1:
            self.head = None
            self.tail = None
        else:
            self.head = self.head.next
        self.length -= 1
        popped_node.next = None
        return popped_node

    def get(self: LinkedList, index: int) -> Node | None:
        if index > self.length or index < 0:
            return None
        temp_node: Node | None = self.head
        for _ in range(index):
            temp_node = temp_node.next
        return temp_node

    def set_value(self: LinkedList, index: int, value: object) -> bool:
        temp_node: Node | None = self.get(index)
        if temp_node:
            temp_node.value = value
            return True
        return False

    def insert(self: LinkedList, index: int, value: object) -> bool:
        # Edge cases:
        # - index is 0, then "Prepend".
        # - index is the length of the list, then "Append"
        # If none of the scenarios above fits, then we'll grab the previous
        # node to the index in question, we'll have the new node point to this
        # previous node's next, and then point the previous node to the new one.
        if index > self.length or index < 0:
            return False
        if index == 0:
            return self.prepend(value)
        if index == self.length:
            return self.append(value)
        new_node: Node = Node(value)
        temp_node = self.get(index - 1)
        new_node.next = temp_node.next
        temp_node.next = new_node
        self.length += 1
        return True

    def remove(self: LinkedList, index: int) -> Node | None:
        if index >= self.length or index < 0:
            return None
        if index == self.length - 1:
            return self.pop()
        if index == 0:
            return self.pop_first()
        previous_node: Node | None = self.get(index - 1)
        node_to_be_removed: Node | None = previous_node.next
        previous_node.next = node_to_be_removed.next
        node_to_be_removed.next = None
        self.length -= 1
        return node_to_be_removed


ll: LinkedList = LinkedList(0)

ll.append(1)
ll.append(2)
ll.append(123456789)
ll.append(3)


ll.print_list_items()
# --------------------------------------------------
# List's length: 5
# Head: '0' - Tail: '3'.
# List's contents: [ 0 1 2 123456789 3 ]
# --------------------------------------------------

something: Node | None = ll.remove(3)

print(something.value if something else "None")
# 123456789

ll.print_list_items()
# --------------------------------------------------
# List's length: 4
# Head: '0' - Tail: '3'.
# List's contents: [ 0 1 2 3 ]
# --------------------------------------------------

ll.remove(3)
ll.print_list_items()
# --------------------------------------------------
# List's length: 3
# Head: '0' - Tail: '2'.
# List's contents: [ 0 1 2 ]
# --------------------------------------------------

ll.remove(0)
ll.print_list_items()
# --------------------------------------------------
# List's length: 2
# Head: '1' - Tail: '2'.
# List's contents: [ 1 2 ]
# --------------------------------------------------
