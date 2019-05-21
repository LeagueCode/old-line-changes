// Header with important information 
//
// Copyright 2018
public class MyClass
{
    public string  myField = string.Empty;

    public MyClass()
    {
    }

    public int MyAutoImplementedProperty { get; set; }
    
    public void MyMethodWichExeedsTheMaximumAllowedLineLengthByFar(int parameter1, string parameter2, bool parameter3, double parameter4)
    {
        Console.WriteLine("First Parameter {0}, second parameter {1}", 
                                                    parameter1, parameter2);
    } 

    private int myPropertyVar;
    
    public int MyProperty
    {
            get { return myPropertyVar; }
            set { myPropertyVar = value; }
    } 
}