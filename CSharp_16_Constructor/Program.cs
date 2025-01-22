internal class Program
{
    private static void Main(string[] args)
    {
        Example e = new Example();
        Example e2 = new Example(15);
        Console.WriteLine(e2.x);
        new Example();
        new Example();
        new Example();
    }
}

class Example
{
    #region Constructor

    // Constructor method should be public. If we don't specify any access modifier, it is private by default.
    // Constructor method name should be same as the class name.
    // Constructor method doesn't have any return type.
    // Constructor method is called when we create an object of the class.
    // Constructor method is a special method of the class that is used to initialize the objects of the class.
    // ** Constructor methods are used to set initial values of the fields of the class.

    public double x { get; set; }
    public Example()
    {
        Console.WriteLine("contructor called");
    }
    public Example(int a)
    {
        x = Math.Pow(a, 2) * Math.PI / 4;
    }
    #endregion

    #region Static Constructor

    // Static Constructor is called even before the first object of the class and the normal constructor is called.
    // Static Constructor is called only once. So, after first initialization, it is not called again.
    // Why would we need static constructor? - To set the initial configuration of the application.
    static Example()
    {
        Console.WriteLine("Static Constructor is called befor normal constructor.");
    }

    #endregion
}