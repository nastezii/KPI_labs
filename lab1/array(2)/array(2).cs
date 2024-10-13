//динамічне додавання ключів
object[] myArray = { true, "cat", 5, 11, -21, false,345, true, "windows", 14.23, 's', 'a', null, null,true, 42 };
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