"""
Write a method called has_loop that is part of the linked list class. 

The method should be able to detect if there is a cycle or loop present in the linked list. 

The method should utilize Floyd's cycle-finding algorithm, 
also known as the "tortoise and hare" algorithm, to determine the presence of a loop efficiently.

----

The method should follow these guidelines:

Create two pointers, slow and fast, both initially 
pointing to the head of the linked list.
Traverse the list with the slow pointer moving one step at a time, 
while the fast pointer moves two steps at a time.
If there is a loop in the list, the fast pointer will eventually 
meet the slow pointer. If this occurs, the method should return True.
If the fast pointer reaches the end of the list or encounters a None value, 
it means there is no loop in the list. In this case, the method should return False.
"""


class Node:
    def __init__(self, value):
        self.value = value
        self.next = None


class LinkedList:
    def __init__(self, value):
        new_node = Node(value)
        self.head = new_node
        self.tail = new_node
        self.length = 1

    def append(self, value):
        new_node = Node(value)
        if self.length == 0:
            self.head = new_node
            self.tail = new_node
        else:
            self.tail.next = new_node  # type: ignore
            self.tail = new_node
        self.length += 1
        return True

    def has_loop(self):
        if self.head is None:
            return False
        fast_node = self.head
        slow_node = self.head
        while fast_node:
            fast_node = fast_node.next
            if slow_node is fast_node:
                return True
            if fast_node is not None:
                fast_node = fast_node.next
                if slow_node is fast_node:
                    return True
            slow_node = slow_node.next
        return False


my_linked_list_1 = LinkedList(1)
my_linked_list_1.append(2)
my_linked_list_1.append(3)
my_linked_list_1.append(4)
my_linked_list_1.tail.next = my_linked_list_1.head  # type: ignore
print(my_linked_list_1.has_loop())  # Returns True


my_linked_list_2 = LinkedList(1)
my_linked_list_2.append(2)
my_linked_list_2.append(3)
my_linked_list_2.append(4)
print(my_linked_list_2.has_loop())  # Returns False


"""
    EXPECTED OUTPUT:
    ----------------
    True
    False
    
"""
