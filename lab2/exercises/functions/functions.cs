//average
static double Average(int firstNum, int secondNum)
{
    return (firstNum + secondNum) / 2;
}

// square
static int Square(int number)
{
    return (int)Math.Pow(number,2);
}

//cube
static int Cube(int number)
{
    return (int)Math.Pow(number, 3);
}

//calculate
static double[] Calculate()
{
    double[] array = new double[10];
    for (int i = 0; i <= 9; i++)
    {
        array[i] = Average(Square(i), Cube(i));
    }
    return array;
}
