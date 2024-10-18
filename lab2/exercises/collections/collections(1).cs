//function for searching the phone by name
(string Name, string Phone)[] contacts = new (string, string)[]
{
    ("Sasha", "+380123987789"),
    ("Nastia", "+380987534321"),
    ("Vlada", "+380346432343")
};

string nameToSearch = "Nastia";
string phone = FindPhoneByName(contacts, nameToSearch);
Console.WriteLine($"Телефон для {nameToSearch}: {phone}");

static string FindPhoneByName((string Name, string Phone)[] contacts, string name)
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

