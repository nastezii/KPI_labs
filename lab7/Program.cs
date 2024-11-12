//Implementation of a function that removes an element from an array.
void RemoveElement(ref int[] array, int item)
{ 
    List<int> list = array.ToList();
    list.Remove(item);
    int[] arr = list.ToArray();
    array = arr;
}

//Function, that removes the selected elements from the array.
void RemoveElements(ref int[] array, params int[] items)
{
    List<int> list = array.ToList();
    foreach (int item in items) { list.Remove(item); }
    int[] arr = list.ToArray();
    array = arr;
}

//A function, that returns a unique array.
int[] UniqueArray(int[] array)
{
    int[] arr = array.Distinct().ToArray();
    return arr;
}

//A function, that returns a new array containing elements from array1 but not containing in array2
int[] Difference(int[] array1, int[] array2)
{
    int[] arr = array1.Except(array2).ToArray();
    return arr;
}
