//статично задані ключі
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
