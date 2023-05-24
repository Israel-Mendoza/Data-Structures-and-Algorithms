var ht = new HashTable();

ht.Set("Israel", 31);
ht.Set("Margarita", 29);
ht.Set("Victor", 28);
ht.Set("Arturo", 72);
ht.Set("Antonia", 56);

foreach (var key in ht.Keys())
    Console.WriteLine(key);