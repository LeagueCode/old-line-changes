public class MyClass
{
    public string  myField = string.Empty;

    private int myPropertyVar;
    
    public int MyProperty
    {
            get { return myPropertyVar; }
            set { myPropertyVar = value; }
    } 
    
    public MyClass()
    {
    }

    public int MyAutoImplementedProperty { get; set; }
    
    public void MyMethodWichDoesNotExeedTheAllowedLineLength(
        int parameter1, 
        string parameter2)
    {
        Console.WriteLine("First Parameter {0}, second parameter {1}", 
                                                    parameter1, parameter2);
    } 
}