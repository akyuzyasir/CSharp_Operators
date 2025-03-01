internal class Program
{
    private static void Main(string[] args)
    {
        Example e1 = new Example();
        e1.ExampleValue = 123;
        if(e1.Equals(e1.Send(123)))
            Console.WriteLine("Objects are equal");
        else
            Console.WriteLine("Objects are not equal");
        Console.Read();
    }
    class Example
    {
        public int ExampleValue { get; set; }
        int x;
        public Example Send(int x)
        {
            this.x = x;
            // This keyword is used to refer to the 'current' instance of the class.
            return this;
        }
    }
}