//A function that iterates over a given object, passing each element to a callback with the following contract

void Ex1()
{ 
    var pairs = new Dictionary<string, int> { { "a", 1 }, { "b", 2 }, { "c", 3 } };
    Iterate(pairs, (key, value) =>
    {
        Console.WriteLine($"{{ key: '{key}', value: {value} }}");
    });

    void Iterate(Dictionary<string, int> pairs, Action<string, int> callback)
    {
        foreach (var pair in pairs)
        {
            callback(pair.Key, pair.Value);
        }
    }
}