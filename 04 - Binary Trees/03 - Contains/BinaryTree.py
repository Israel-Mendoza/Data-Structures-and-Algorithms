from __future__ import annotations


class Node:
    def __init__(self: Node, value: int) -> None:
        self.value: int = value
        self.left: Node | None = None
        self.right: Node | None = None


class BinaryTree:
    def __init__(self: BinaryTree) -> None:
        # We won't create an initial Node. The root will be None.
        self._root: Node | None = None

    @property
    def root(self: BinaryTree) -> Node | None:
        return self._root

    def insert(self: BinaryTree, new_value: int) -> bool:
        new_node: Node | None = Node(new_value)
        if self.root is None:
            self._root = new_node
            return True
        temp_node: Node | None = self.root
        while True:
            if new_node.value == temp_node.value:
                return False
            if new_node.value > temp_node.value:
                if temp_node.right is None:
                    temp_node.right = new_node
                    return True
                temp_node = temp_node.right
            else:
                if temp_node.left is None:
                    temp_node.left = new_node
                    return True
                temp_node = temp_node.left

    def contains(self: BinaryTree, value: int) -> bool:
        temp_node: Node | None = self.root
        # If the temp_node is None, it won't access the loop
        while temp_node is not None:
            if value == temp_node.value:
                return True
            if value > temp_node.value:
                temp_node = temp_node.right
            else:
                temp_node = temp_node.left
        return False


bt: BinaryTree = BinaryTree()

bt.insert(47)
bt.insert(21)
bt.insert(76)
bt.insert(18)
bt.insert(27)
bt.insert(52)
bt.insert(82)
bt.insert(15)
bt.insert(19)
bt.insert(25)
bt.insert(30)
bt.insert(49)
bt.insert(59)
bt.insert(77)
bt.insert(90)

#                     47
#          21                        76
#    18          27            52          82
# 15    19    25    30      49    59    77    90

print(bt.contains(47))
# True
print(bt.contains(21))
# True
print(bt.contains(25))
# True
print(bt.contains(76))
# True
print(bt.contains(52))
# True
print(bt.contains(77))
# True
print(bt.contains(0))
# False
print(bt.contains(100))
# False
