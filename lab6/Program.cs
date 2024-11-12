// Pipe<T> composes functions of type Func<T, T>, applying them to the input value sequentially.
// If the arguments are not functions of this type, an exception is thrown.
//Example:
Func<int, int> inc = x => ++x;
Func<int, int> twice = x => x * 2;
Func<int, int> cube = x => x * x * x;
var f1 = FunctionComposer.Pipe<int>(inc, twice, cube);
Console.WriteLine(f1(5));//Output: 1728

public static class FunctionComposer
{
    public static Func<T, T> Pipe<T>(params Delegate[] funcs)
    {
        foreach (var func in funcs)
        {
            if (func is not Func<T, T>)
            {
                throw new ArgumentException("All arguments must be functions of type Func<T, T>.");
            }
        }
        return x =>
        {
            T result = x;
            foreach (Func<T, T> func in funcs) { result = func(result); }
            return result;
        };
    }
}