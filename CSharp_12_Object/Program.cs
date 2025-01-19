using CSharp_12_Object;

internal class Program
{
    private static void Main(string[] args)
    {
        int number = 0;
        Example abc = new Example(); // Creating an object of class Example and assigning it to abc. abc is a reference to the object. In stack memory, abc is stored and in heap memory, object of class Example is stored.

        Example x = null; // Declaring a reference to an object of class Example but not creating an object. x is stored in stack memory.
        x = new Example(); // Creating an object of class Example and assigning it to x. x is a reference to the object. 

        Example a = new Example();
        Example b = a; // b is a reference to the object that a is referencing. Both a and b are pointing to the same object. If we change the object using a, b will also reflect the changes.

        


        int k = 10;
        int l = k; // l is a copy of k. If we change k, l will not reflect the changes.

    }
}