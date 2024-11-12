// Implementing functions that sum their arguments using various loops or methods:

// Using for loop:
int Sum1(params int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    return sum;
}

// Using foreach loop:
int Sum2(params int[] numbers)
{
    int sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }
    return sum;
}

// Using while loop:
int Sum3(params int[] numbers)
{
    int sum = 0;
    int count = 0;
    while (count < numbers.Length)
    {
        sum += numbers[count];
        count++;
    }
    return sum;
}

// Using do-while loop:
int Sum4(params int[] numbers)
{
    int sum = 0;
    int count = 0;
    do
    {
        sum += numbers[count];
        count++;
    } while (count < numbers.Length);
    return sum;
}

// Using LINQ:
int Sum5(params int[] numbers)
{
    return numbers.Sum();
}

// A function that finds the maximum number in a two-dimensional array:
int MaxValueInArray(int[,] array)
{
    return array.Cast<int>().Max();
}

// Iterating over dictionaries:
var persons = new Dictionary<string, (int born, int died)>
{
    { "Albert Einstein", (1879, 1955) },
    { "Marie Curie", (1867, 1934) },
    { "Isaac Newton", (1643, 1727) },
    { "Leonardo da Vinci", (1452, 1519) }
};
var lifeSpans = CalculateAges(persons);
foreach (var person in lifeSpans)
{
    Console.WriteLine($"{person.Key}: {person.Value} years");
}

// A function that calculates the age based on birth and death years:
Dictionary<string, int> CalculateAges(Dictionary<string, (int born, int died)> persons)
{
    var lifeSpans = new Dictionary<string, int>();
    foreach (var person in persons)
    {
        var age = person.Value.died - person.Value.born;
        lifeSpans[person.Key] = age;
    }
    return lifeSpans;
}