internal class Program
{
    private static void Main(string[] args)
    {
        Mathematics m = new Mathematics();
        m.Sum(5, 10);
        m.Sum(5.5, 10.2);
    }
    class Mathematics
    {
        // Method Overloading is a feature that allows a class to have more than one method having the same name, if their argument lists are different. In order to overload a method, the argument lists of the methods must differ in either of these: 1. Number of parameters. 2. Data type of parameters. 3. Sequence of Data type of parameters. 
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public double Sum(double a, double b)
        {
            return a + b;
        }
        public int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Sum(double a, double b, double c)
        {
            return a + b + c;
        }
    }
}