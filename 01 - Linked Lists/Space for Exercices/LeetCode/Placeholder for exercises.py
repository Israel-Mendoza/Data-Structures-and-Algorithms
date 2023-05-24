"""
Implement the find_kth_from_end function, 
which takes the LinkedList (ll) and an integer k as input, 
and returns the k-th node from the end of the linked list WITHOUT USING LENGTH. 

If the linked list has fewer than k items, the program should return None.

The find_kth_from_end function should follow these requirements:
The function should utilize two pointers, slow and fast, initialized 
to the head of the linked list.
The fast pointer should move k nodes ahead in the list.
If the fast pointer becomes None before moving k nodes, the function s
hould return None, as the list is shorter than k nodes.
The slow and fast pointers should then move forward in the list at the 
same time until the fast pointer reaches the end of the list.
The function should return the slow pointer, which will be at the k-th 
position from the end of the list.

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


def find_kth_from_end(a_list, k):
    temp = a_list.head
    for _ in range(k):
        temp = temp.next
        if temp is None:
            return False


my_linked_list = LinkedList(1)
my_linked_list.append(2)
my_linked_list.append(3)
my_linked_list.append(4)
my_linked_list.append(5)


k = 2
result = find_kth_from_end(my_linked_list, k)

print(result.value)  # Output: 4


"""
    EXPECTED OUTPUT:
    ----------------
    4
    
"""
