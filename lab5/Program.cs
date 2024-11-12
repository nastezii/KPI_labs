//A class,that allows executing a sequence of functions, each of which takes and returns an int value.
// Example:
Console.WriteLine(new Sequence(x => x + 7, x => x * 2).Execute(5)); //Output: 24

public class Sequence
{
    private Func<int, int>[] functions;
    public Sequence(params Func<int, int>[] funcs)
    {
        functions = funcs;
    }
    public int Execute(int initialValue)
    {
        int result = initialValue;
        foreach (var func in functions) { result = func(result); }
        return result;
    }
}

// Class Array, which contains a list of elements and provides an interface for accessing it:
// methods for retrieving an element by index, adding a new element, and removing the last element.
public class Array
{ 
    private List<object> elements = new List<object>();
    public object GetElement(int index) { return index >= 0 && index < elements.Count ? elements[index] : null; }
    public void Push (object value) { elements.Add(value); }
    public object Pop()
    {
        if (elements.Count == 0) { return null; }
        var lastElement = elements[elements.Count - 1];
        elements.RemoveAt(elements.Count - 1);
        return lastElement;
    }
}