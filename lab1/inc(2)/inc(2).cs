//друга реалiзацiя inc
static void Inc (ref int n)
{
    n++;
}
int n = 5;
Inc(ref n);
Console.WriteLine($"n = {n}");
