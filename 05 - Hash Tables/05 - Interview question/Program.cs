// Provided you have two lists, create a function that will say if there are items in common.

// True:

// 1. [1, 4, 7]
// 2. [2, 5, 7]

// False:

// 1. [1, 4, 7]
// 2. [2, 5, 8]

var list_one = new List<int>
{
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
};

var list_two = new List<int>
{
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
};

// # Naive attempt. O(n2)
bool ItemInCommon(List<int> l1, List<int> l2)
{
    int perfCounter = 0;
    foreach (var num1 in l1)
        foreach (var num2 in l2)
        {
            perfCounter++;
            if (num1 == num2)
            {
                Console.WriteLine($"Performance counter: {perfCounter}");
                return true;
            }
        }
    Console.WriteLine($"Performance counter: {perfCounter}");
    return false;
}

// Using hash tables O(2n):
bool ItemInCommonv2(List<int> l1, List<int> l2)
{
    int perfCounter = 0;
    var placeholderDict = new Dictionary<int, bool>();
    foreach (var num in l1)
    {
        perfCounter++;
        placeholderDict.Add(num, true);
    }
    foreach (var num in l2)
    {
        perfCounter++;
        if (placeholderDict.ContainsKey(num))
        {
            Console.WriteLine($"Performance counter: {perfCounter}");
            return true;
        }
    }
    Console.WriteLine($"Performance counter: {perfCounter}");
    return false;
}

Console.WriteLine(ItemInCommon(list_one, list_two));
// Performance counter: 324
// False

Console.WriteLine(ItemInCommonv2(list_one, list_two));
// Performance counter: 36
// False

list_two.Add(59);

Console.WriteLine(ItemInCommon(list_one, list_two));
// Performance counter: 342
// True
Console.WriteLine(ItemInCommonv2(list_one, list_two));
// Performance counter: 37
// True
