//перша реалiзацiя inc
static int Inc(int a)
{
    return a++;
}
int a = 10;
int b = Inc(a);
Console.WriteLine($"a={a}, b={b}");