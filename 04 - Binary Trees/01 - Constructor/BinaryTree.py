from __future__ import annotations
from typing import Any


class Node:
    def __init__(self: Node, value: Any) -> None:
        self.value: Any = value
        self.left: Node | None = None
        self.right: Node | None = None


class BinaryTree:
    def __init__(self: BinaryTree) -> None:
        # We won't create an initial Node. The root will be None.
        self.root: Node | None = None


my_bt: BinaryTree = BinaryTree()

print(my_bt.root)  # None
