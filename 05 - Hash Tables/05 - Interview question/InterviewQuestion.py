# Provided you have two lists, create a function that will say if there are items in common.

# True:

# 1. [1, 4, 7]
# 2. [2, 5, 7]

# False:

# 1. [1, 4, 7]
# 2. [2, 5, 8]


list_one: list[int] = [
    1,
    2,
    3,
    5,
    7,
    11,
    13,
    17,
    19,
    23,
    29,
    31,
    37,
    41,
    43,
    47,
    53,
    59,
]
list_two: list[int] = [
    0,
    4,
    6,
    8,
    8,
    10,
    12,
    14,
    15,
    16,
    18,
    20,
    21,
    22,
    24,
    25,
    26,
    27,
]


# Naive attempt. O(n2)
def item_in_common(l1: list[int], l2: list[int]) -> bool:
    perf_counter: int = 0
    for num1 in l1:
        for num2 in l2:
            perf_counter += 1
            if num1 == num2:
                print(f"Performance counter: {perf_counter}")
                return True
    print(f"Performance counter: {perf_counter}")
    return False


# Using hash tables O(2n):
def item_in_common_v2(l1: list[int], l2: list[int]) -> bool:
    perf_counter: int = 0
    placeholder_dict: dict[int, bool] = {}
    for num in l1:
        perf_counter += 1
        placeholder_dict[num] = True
    for num in l2:
        perf_counter += 1
        if num in placeholder_dict:
            print(f"Performance counter: {perf_counter}")
            return True
    print(f"Performance counter: {perf_counter}")
    return False


print(item_in_common(list_one, list_two))
# Performance counter: 324
# False

print(item_in_common_v2(list_one, list_two))
# Performance counter: 36
# False

list_one.append(59)

print(item_in_common(list_one, list_two))
# Performance counter: 342
# True

print(item_in_common_v2(list_one, list_two))
# Performance counter: 37
# True
