//Ex1_1:a function, that returns a random number
int Random1(int minValue, int maxValue)
{
    Random random = new Random();
    return random.Next(minValue, maxValue);
}

//Ex1_2:a function, that returns a random number, starting at 0
int Random2(int maxValue, int minValue = 0)
{
    return Random1(minValue, maxValue);
}

//Ex2:function, that returns a string of random characters from a set
string characters = "39fuinfwui7867gfuw783";
int lenght = 10;
string randomKey = GenerateKey(characters, lenght);
Console.WriteLine(randomKey);
string GenerateKey (string characters, int lenght)
{
    Random random = new Random();
    char[] key = new char[lenght];
    for (int i = 0; i < key.Length; i++)
    {
        key[i] = characters[random.Next(characters.Length)];
    }
    return new string(key);
}

//Ex3:function, that converts an IP address into a number containing 4 bytes of the address
string ipAddress = "10.0.0.1"; 
Console.WriteLine(ConvertIpToNumber(ipAddress));
int ConvertIpToNumber(string ip)
{
    int[] bytes = ip.Split('.').Select(int.Parse).ToArray();
    int result = 0;
    for (int i = 0; i < bytes.Length; i++)
    {
        result += bytes[i] << (8 * (3 - i));
    }
    return result;
}

//Ex4:implementation of object introspection
var iface = new
{
    m1 = new Func<int, int>(x => x),
    m2 = new Func<int, int, int>((x, y) => x + y),
    m3 = new Func<int, int, int, int>((x, y, z) => x + y + z)
};
var result = InspectObjectMethods(iface);
foreach (var row in result)
{
    Console.WriteLine($"Method: {row[0]}, Parameter Count: {row[1]}");
}
List<object[]> InspectObjectMethods(object obj)
{
    var methodsInfo = new List<object[]>();
    Type type = obj.GetType();
    var properties = type.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);

    foreach (var property in properties)
    {
        if (property.PropertyType.IsSubclassOf(typeof(Delegate)))
        {
            int parameterCount = property.PropertyType.GetMethod("Invoke").GetParameters().Length;
            methodsInfo.Add(new object[] { property.Name, parameterCount });
        }
    }

    return methodsInfo;
}