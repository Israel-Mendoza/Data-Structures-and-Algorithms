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
        return True

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

    def prepend(self, value):
        new_node = Node(value)
        if self.length == 0:
            self.head = new_node
            self.tail = new_node
        else:
            new_node.next = self.head
            self.head = new_node
        self.length += 1
        return True

    def pop_first(self):
        if self.length == 0:
            return None
        temp_node = self.head
        if self.length == 1:
            self.head = None
            self.tail = None
        else:
            self.head = temp_node.next
            temp_node.next = None
        self.length -= 1
        return temp_node

    def get(self, index):
        if index < 0 or index >= self.length:
            return None
        temp = self.head
        for _ in range(index):
            temp = temp.next
        return temp

    def set_value(self, index, value):
        temp_node = self.get(index)
        if temp_node:
            temp_node.value = value
            return True
        return False

    def insert(self, index, value):
        if index < 0 or index > self.length:
            return False
        if index == 0:
            return self.prepend(value)
        if index == self.length:
            return self.append(value)
        new_node = Node(value)
        previous_node = self.get(index - 1)
        new_node.next = previous_node.next
        previous_node.next = new_node
        self.length += 1
        return True

    def remove(self, index):
        if index < 0 or index >= self.length:
            return None
        if index == 0:
            return self.pop_first()
        if index == self.length - 1:
            return self.pop()
        temp_1 = self.head
        temp_2 = self.head
        for _ in range(index):
            temp_2 = temp_1
            temp_1 = temp_1.next
        temp_2.next = temp_1.next
        temp_1.next = None
        self.length -= 1
        return temp_1

    def reverse(self):
        self.head, self.tail = self.tail, self.head
        if self.length < 2:
            return
        # if self.length == 2:
        #     self.head
        temp_main = self.tail
        temp_right = self.tail.next
        temp_left = None
        for _ in range(self.length - 1):
            temp_main.next = temp_left
            temp_left = temp_main
            temp_main = temp_right
            temp_right = temp_right.next
        self.head.next = temp_left


dll = LinkedList(0)
dll.append(1)

dll.print_list()
dll.reverse()
dll.print_list()
