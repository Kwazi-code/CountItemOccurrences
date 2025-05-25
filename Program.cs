using System;
using System.Collections.Generic;

class Program
{
    static void CountItems<T>(List<T> items)
    {
        Dictionary<T, int> counts = new Dictionary<T, int>();

        foreach (T item in items)
        {
            if (counts.ContainsKey(item))
            {
                counts[item] = counts[item] + 1;
            }
            else
            {
                counts[item] = 1;
            }
        }

        foreach (var pair in counts)
        {
            Console.WriteLine(pair.Key + ": " + pair.Value);
        }
    }

    static void Main()
    {
        var list1 = new List<string> { "apple", "banana", "apple", "orange", "banana", "apple" };
        var list2 = new List<int> { 1, 2, 2, 3, 1, 4, 2 };

        Console.WriteLine("String list:");
        CountItems(list1);

        Console.WriteLine("\nInteger list:");
        CountItems(list2);
    }
}
