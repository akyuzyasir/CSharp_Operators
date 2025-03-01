internal class Program
{
    private static void Main(string[] args)
    {
        Example example = new Example();
        Human human = new Human();
        human[3] = "John";
        human[5] = "Jane";

        Console.WriteLine(human[3]);
        Console.WriteLine(human[5]);
        Console.WriteLine(human[18]);

        Console.Read();
        // Indexers make it possible to access elements in a class like an array. By using indexers, you can define the behavior of the class when accessed like an array. 
    }
    class Human
    {
        string[] Names = new string[10];
        public string this[int i]
        {
            get
            {
                return Names[i];
            }
            set
            {
                Names[i] = value;
            }
        }

        public string this[string x]
        {
            get
            {
                return "";
            }
            set
            {

            }
        }
    }
    class Example
    {
        #region Indexer
        // Indexer is a special type of property that allows a class or struct to be accessed like an array for its instance.
        public string this[int index]
        {
            get
            {
                return "";
            }
            set
            {

            }
        }
        #endregion
    }
}