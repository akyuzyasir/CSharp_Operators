using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        // In Arrays we have to specify the size of the array at the time of declaration. However, we may not know the size of the array at the time of declaration.
        // Even though we don't assign any value to the array, it still occupies memory.
        // It has more overhead in terms of memory during read and write operations.
        #region ArrayList
        ArrayList myArrayList = new ArrayList();
        myArrayList.Add("Jane");
        myArrayList.Add("Jone");
        myArrayList.Add(1);
        myArrayList.Add(false);
        myArrayList.Add('A');

        // ArrayList is a non-generic collection of objects whose size can increase dynamically.
        // ArrayList can store multiple data types. But the performance of the ArrayList is slow because it stores data in the form of objects. So, everytime we call an element from the ArrayList, it needs to be unboxed. This is a time-consuming process.

        foreach(var item in myArrayList)
        {
            if(item is int)
            {
                Console.WriteLine((int)item+120);
            }
        }

        //Console.WriteLine(typeof(myArrayList[1])); 
        //foreach (var item in myArrayList)
        //{
        //    Console.WriteLine(item);
        //}   

        #endregion

        #region List
        List<string> myList = new List<string>();
        myList.Add("Jane");
        myList.Add("Jone");
        myList.Add("Ackuse");  // Add method is used to add elements to the list.
        var newList = myList.Append("haha"); // Append method adds an element to the end of the list and returns a new lsit.
        foreach(var item in newList)
        {
            Console.WriteLine(item);
        }
        //Console.WriteLine(myList.Last());
        #endregion
    }
}