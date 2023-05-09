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

    def print_list(self):
        temp = self.head
        while temp is not None:
            print(temp.value)
            temp = temp.next
            
    def make_empty(self):
        self.head = None
        self.tail = None
        self.length = 0
        
    def append(self, value):
        new_node = Node(value)
        if self.head == None:
            self.head = new_node
            self.tail = new_node
        else:
            self.tail.next = new_node
            self.tail = new_node
        self.length += 1

    def pop(self):
        if self.length == 0:
            return None
        if self.length == 1:
            temp_node = self.head
            self.head = None
            self.tail = None
            return temp_node
        temp_node = self.head
        while temp_node.next != self.tail:
            temp_node = temp_node.next
        to_be_returned = temp_node.next
        self.tail = temp_node
        self.tail.next = None
        return to_be_returned
