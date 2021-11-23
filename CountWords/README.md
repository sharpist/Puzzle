# Find how many times each word occurs in the initial string

#### The method of counting duplicate words in the entered text:

```C#
IDictionary<String, Int32> CountWords(String text)
{
    var words = text?.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',', '-' },
                            StringSplitOptions.RemoveEmptyEntries) ?? new String[] { };

    Dictionary<string, int> results = new();

    _ = (from   word in words
         let    lower = word.ToLowerInvariant()
         where !results.ContainsKey(lower)
         select results[lower] = (from   word in words
                                  where  word.ToLowerInvariant() == lower
                                  select word).Count()
        ).ToArray();

    return results;
}
```

#### Usage:

```C#
var results = CountWords("Quod cito fit, cito perit.");

foreach (var result in results)
{
    Console.WriteLine($"{result.Key}\t{result.Value}");
}
// quod    1
// cito    2
// fit     1
// perit   1
```
