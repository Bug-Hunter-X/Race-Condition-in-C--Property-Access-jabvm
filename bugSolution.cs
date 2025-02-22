public class ExampleClass
{
    private int _myProperty;
    private readonly object _lock = new object();

    public int MyProperty
    {
        get { lock (_lock) { return _myProperty; } }
        set { lock (_lock) { _myProperty = value; } }
    }

    public void MyMethod()
    {
        // ... some code ...
        lock (_lock)
        {
            MyProperty = 10;
        }
    }
}