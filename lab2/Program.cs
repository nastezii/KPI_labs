﻿//Ex1_1: identifiers
void Ex1_1()
{
    string name = "Anastasia";
    const int yearOfBirth = 2006;
    static void PrintGreeting(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
    PrintGreeting(name);
}

//Ex2_1: a function that returns an array of numbers from a range, including extreme numbers
int[] Range(int firstNum, int secondNum)
{
    int size = secondNum - firstNum + 1;
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = firstNum + i;
    }
    return array;
}

//Ex2_2: a function that returns an array of odd numbers from the range , including extreme numbers
int[] RangeOdd(int firstNum, int secondNum)
{
    int size = 0;
    for (int i = firstNum; i <= secondNum; i++)
    {
        if (i % 2 != 0)
        {
            size++;
        }
    }
    int[] array = new int[size];
    int index = 0;
    for (int i = firstNum; i <= secondNum; i++)
    {
        if (i % 2 != 0)
        {
            array[index] = i;
            index++;
        }
    }
    return array;
}

//Ex3_1: average
double Average(int firstNum, int secondNum)
{
    return (firstNum + secondNum) / 2;
}

//Ex3_2: square
int Square(int number)
{
    return (int)Math.Pow(number, 2);
}

//Ex3_3: cube
int Cube(int number)
{
    return (int)Math.Pow(number, 3);
}

//Ex3_4: calculate
double[] Calculate()
{
    double[] array = new double[10];
    for (int i = 0; i <= 9; i++)
    {
        array[i] = Average(Square(i), Cube(i));
    }
    return array;
}

//Ex4_1: function that create a user object
object CreateUser(string name, string city)
{
    return new { Name = name, City = city };
}

//Ex5_1: function for searching the phone by name
void Ex5_1()
{
    (string Name, string Phone)[] contacts = new (string, string)[]
    {
        ("Sasha", "+380123987789"),
        ("Nastia", "+380987534321"),
        ("Vlada", "+380346432343")
    };

    string FindPhoneByName1((string Name, string Phone)[] contacts, string name)
    {
        for (int i = 0; i < contacts.Length; i++)
        {
            if (contacts[i].Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                return contacts[i].Phone;
            }
        }
        return "Phone not found";
    }
    string nameToSearch = "Nastia";
    string phone = FindPhoneByName1(contacts, nameToSearch);
    Console.WriteLine($"Телефон для {nameToSearch}: {phone}");
}

//Ex5_2: function for searching the phone by name
void Ex5_2()
{
    Dictionary<string, string> contacts1 = new Dictionary<string, string>
{
    { "Sasha", "+380123987789" },
    { "Nastia", "+380987534321" },
    { "Vlada", "+380346432343" }
};

    string FindPhoneByName2(string name)
    {
        if (contacts1.TryGetValue(name, out string phone))
        {
            return phone;
        }
        return "Phone not found";
    }

    Console.WriteLine("Enter the name to search for a phone number:");
    string nameToSearch2 = Console.ReadLine();
    string phone2 = FindPhoneByName2(nameToSearch2);
    Console.WriteLine($"Телефон для {nameToSearch2}: {phone2}");
}