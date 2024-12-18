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

//A function that iterates over the first argument and checks the argument types and the result type.

void Ex3()
{
    var add = (int a, int b) => a + b;
    var addNumbers = Contract(add);
    Console.WriteLine(addNumbers(2, 3)); 

    var concat = (string s1, string s2) => s1 + s2;
    var concatStrings = Contract(concat);
    Console.WriteLine(concatStrings("Hello ", "world!"));

    Func<T1, T2, TResult> Contract<T1, T2, TResult>(Func<T1, T2, TResult> function)
    {
        return (arg1, arg2) =>
        {
            if (arg1 is not T1 || arg2 is not T2) { throw new ArgumentException("Invalid argument types."); }

            TResult result = function(arg1, arg2);

            if (result is not TResult) { throw new ArgumentException("Invalid result type.");  }

            return result;
        };
     }
}