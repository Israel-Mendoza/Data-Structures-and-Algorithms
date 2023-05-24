from __future__ import annotations
from typing import Any


class HashTable:
    def __init__(self: HashTable, size: int = 7) -> None:
        self.data_map: list[Any] = [None] * size

    def __hash(self: HashTable, key: str) -> int:
        my_hash: int = 0
        for char in key:
            my_hash = (my_hash + ord(char) * 23) % len(self.data_map)
        return my_hash

    def print_table(self: HashTable) -> None:
        for index in range(len(self.data_map)):
            print(f"Address #{index}: ")
            if self.data_map[index] is not None:
                for kv_pair in self.data_map[index]:
                    print(f"Key: {kv_pair[0]} - Value: {kv_pair[1]}")
            print()

    def set_item(self: HashTable, key: str, value: int) -> None:
        # Figuring out the address using the hash method:
        address: int = self.__hash(key)
        if self.data_map[address] == None:
            # We'll create an empty list there.
            self.data_map[address] = []
        # Appending the key-value list to the main list in the index
        self.data_map[address].append([key, value])

    def get(self: HashTable, key: str) -> int | None:
        # What is the address we must be addressing?
        address: int = self.__hash(key)
        # Iterating through the list at that address if it's not None:
        if self.data_map[address] is not None:
            for item in self.data_map[address]:
                if item[0] == key:  # If the key matches the desired string
                    return item[1]
        return None


ht: HashTable = HashTable()

ht.set_item("Israel", 31)
ht.set_item("Margarita", 29)
ht.set_item("Victor", 28)
ht.set_item("Arturo", 72)
ht.set_item("Antonia", 56)

print(ht.get("Israel"))
# 31
print(ht.get("Victor"))
# 28
print(ht.get("Antonia"))
# 56
print(ht.get("Roberto"))
# None
