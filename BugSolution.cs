public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Solution 1: Null check using the null-coalescing operator.
        string s = MyProperty.ToString(); //This line will throw exception if MyProperty is 0. 
        string s1 = MyProperty == 0 ? "0" : MyProperty.ToString();

        //Solution 2: Using string interpolation to handle potential null values.
        string s2 = $"{MyProperty}"; // This implicitly handles null values, outputting "0".
    }
} 