using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
            new Example(i);


        Console.WriteLine("*************");

        GC.Collect();

        Console.Read();

    }

    class Example
    {
        int number;
        public Example(int id)
        {
            number = id;
            Console.WriteLine(number + " object is created.");
        }

        // Destructor is used to destroy the object. A destructor is a special member function of the class and it is used to destroy the object.
        ~Example()
        {
            Console.WriteLine(number + " object is destroyed.");
        }
    }
}