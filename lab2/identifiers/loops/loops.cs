//a function that returns an array of numbers from a range, including extreme numbers
static int[] Range (int firstNum, int secondNum)
{
    int size = secondNum - firstNum + 1;
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = firstNum + i;
    }
    return array;
}

//a function that returns an array of odd numbers from the range , including extreme numbers
static int[] RangeOdd(int firstNum, int secondNum)
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

