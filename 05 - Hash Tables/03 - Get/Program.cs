var ht = new HashTable();

ht.Set("Israel", 31);
ht.Set("Margarita", 29);
ht.Set("Victor", 28);
ht.Set("Arturo", 72);
ht.Set("Antonia", 56);

Console.WriteLine(ht.Get("Margarita"));
// 29
Console.WriteLine(ht.Get("Victor"));
// 28
Console.WriteLine(ht.Get("Arturo"));
// 72
Console.WriteLine(ht.Get("Roberto"));
//