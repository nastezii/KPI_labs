//First implementation of increment function 
int Inc1(int a)
{
    return a++;
}
void Ex1_1()
{
    int a = 10;
    int b = Inc1(a);
    Console.WriteLine($"a={a}, b={b}");
}

void Ex1_2()
{
    int n = 5;
    Inc2(ref n);
    Console.WriteLine($"n = {n}");
}
//Second implementation of increment function (using 'ref' for pass-by-reference)
void Inc2(ref int n)
{
    n++;
}

//Count occurrences of different types in a statically defined array
void Ex2_1()
{
    object[] myArray = { true, "cat", 5, 11, -21, false, 345, true, "windows", 14.23, 's', 'a', null, null, true, 42 };
    Dictionary<string, int> typeCounts = new Dictionary<string, int>
    {
        { "Null", 0 },
        { "Boolean", 0 },
        { "String", 0 },
        { "Int32", 0 },
        { "Double", 0 },
        { "Char", 0 },
    };
    for (int i = 0; i < myArray.Length; i++)
    {
        string typeName = myArray[i] == null ? "Null" : myArray[i].GetType().Name;

        if (typeCounts.ContainsKey(typeName))
        {
            typeCounts[typeName]++;
        }
    }
    List<string> keys = typeCounts.Keys.ToList();
    for (int i = 0; i < keys.Count; i++)
    {
        string key = keys[i];
        Console.WriteLine($"{key}: {typeCounts[key]}");
    }
}

//Count occurrences of different types in a dynamically defined array
void Ex2_2()
{
    object[] myArray = { true, "cat", 5, 11, -21, false, 345, true, "windows", 14.23, 's', 'a', null, null, true, 42 };
    Dictionary<string, int> typeCounts = new Dictionary<string, int>();

    for (int i = 0; i < myArray.Length; i++)
    {
        string typeName = myArray[i] == null ? "Null" : myArray[i].GetType().Name;
        if (typeCounts.ContainsKey(typeName))
        {
            typeCounts[typeName]++;
        }
        else
        {
            typeCounts[typeName] = 1;
        }
    }
    List<string> keys = typeCounts.Keys.ToList();

    for (int i = 0; i < keys.Count; i++)
    {
        string key = keys[i];
        Console.WriteLine($"{key}: {typeCounts[key]}");
    }
}
