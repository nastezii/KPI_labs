//function for searching the phone by name
Dictionary<string, string> contacts = new Dictionary<string, string>
{
    { "Sasha", "+380123987789" },
    { "Nastia", "+380987534321" },
    { "Vlada", "+380346432343" }
};
string FindPhoneByName(string name)
{
    if (contacts.TryGetValue(name, out string phone))
    {
        return phone;
    }
    return "Phone not found"; 
}

Console.WriteLine("Enter the name to search for a phone number:");
string nameToSearch = Console.ReadLine();
string phone = FindPhoneByName(nameToSearch);
Console.WriteLine($"Телефон для {nameToSearch}: {phone}");