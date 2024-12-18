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


//A function that stores a value inside the closure of a returning function.
//After calling the returning function, it will return the value with the closure.

void Ex2()
{
    var read = Store(5);
    Console.WriteLine(read());
    Func<int> Store(int value)
    {
        return () => value;
    }
}
