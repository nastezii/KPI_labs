// Pipe composes functions, applying them to the input value sequentially.
// If the arguments are not functions of this type, an exception is thrown.
Func<T, T> Pipe1<T>(params object[] funcs)
{
    foreach (var func in funcs)
    {
        if (func is not Func<T, T>)
        {
            throw new ArgumentException("All arguments must be functions");
        }
    }
    return x =>
    {
        T result = x;
        foreach (Func<T, T> func in funcs) { result = func(result); }
        return result;
    };
}

//A class, that allows you to chain functions and handle errors at runtime.
public class FunctionComposer
{
    private List<Action<Exception>> errorHandlers = new List<Action<Exception>>();

    public Func<T, T> Pipe<T>(params object[] funcs)
    {
        return x =>
        {
            T result = x;
            foreach (var func in Reverse(funcs))
            {
                if (func is Func<T, T> function) 
                {
                    try
                    {
                        result = function(result);
                    }
                    catch (Exception exception)
                    {
                        foreach (var handler in errorHandlers)
                        {
                            handler(exception);
                        }
                        return default;
                    }
                }
                else
                {
                    foreach (var handler in errorHandlers)
                    {
                        handler(new InvalidOperationException("Element is not a function"));
                    }
                    return default;
                }
            }
            return result;
        };
    }

    public void OnError(Action<Exception> errorHandler)
    {
        errorHandlers.Add(errorHandler);
    }

    private IEnumerable<T> Reverse<T>(IEnumerable<T> sequence)
    {
        var list = new List<T>(sequence);
        list.Reverse();
        return list;
    }
}

