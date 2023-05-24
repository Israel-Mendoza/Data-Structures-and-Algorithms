from __future__ import annotations


class HashTable:
    def __init__(self: HashTable, size: int = 7) -> None:
        self.data_map: list[object] = [None] * size

    def __hash(self: HashTable, key: str) -> int:
        my_hash: int = 0
        for char in key:
            my_hash = (my_hash + ord(char) * 23) % len(self.data_map)
            print(f"Calculation: {my_hash}")
        print(f"Final calculation: {my_hash}")
        return my_hash
