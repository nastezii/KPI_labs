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

