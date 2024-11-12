//implementation of a function that removes an element from an array.
void RemoveElement(ref int[] array, int item)
{ 
    List<int> list = array.ToList();
    list.Remove(item);
    int[] arr = list.ToArray();
    array = arr;
}
