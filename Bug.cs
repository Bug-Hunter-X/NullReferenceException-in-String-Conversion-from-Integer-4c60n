public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // This line throws a NullReferenceException if MyProperty is 0.
        string s = MyProperty.ToString();
    }
}