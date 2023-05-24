"""
Implement the find_middle_node method for the LinkedList class. 

The find_middle_node method should return the middle node in 
the linked list WITHOUT using the length attribute.

If the linked list has an even number of nodes, return the first 
node of the second half of the list.
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

    def append(self, value):
        new_node = Node(value)
        if self.head == None:
            self.head = new_node
            self.tail = new_node
        else:
            self.tail.next = new_node
            self.tail = new_node
        return True

    def find_middle_node(self):
        if self.head is None:
            return None
        slow_node = self.head
        fast_node = self.head
        while fast_node:  # As long as the node is not None
            fast_node = fast_node.next
            if fast_node is not None:
                fast_node = fast_node.next
            else:
                break
            slow_node = slow_node.next
        return slow_node


my_linked_list = LinkedList(0)
my_linked_list.append(1)
my_linked_list.append(2)
my_linked_list.append(3)
my_linked_list.append(4)
# my_linked_list.append(5)

print(my_linked_list.find_middle_node().value)


"""
    EXPECTED OUTPUT:
    ----------------
    3
    
"""
