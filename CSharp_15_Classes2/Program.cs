internal class Program
{
    private static void Main(string[] args)
    {
        School s = new School();
        School.Teacher teacher = new School.Teacher();

        Student student = new Student();
    }
}
class School
{
    // Access Modifier of this class is by default internal.
    internal class Teacher
    {
        // In Nested classes, access modifier is optional. By default, it is private. In order to access it in Program class (outside the School class), we need to make it internal.
    }
}

class Student
{
    #region Field
    // Field is a variable that is declared directly in a class or struct. Fields are members of their containing type. Fields of classes are also known as fields or data members. Fields can be of any type, including other classes. Fields are declared using field declaration syntax. Field declarations are permitted in classes, structs, and interfaces. Fields are initialized immediately before the constructor for the object instance is called. If the field is a static field, initialization occurs before the static constructor for the class is called. Fields are of two types: 1. Instance Fields 2. Static Fields
    // We generally use private access modifier for fields. Because we don't want to expose the fields to the outside world. We want to encapsulate the fields.
    private string name;
    #endregion

    #region Property
    // Properties are used to access the fields of a class. Properties are a way to expose the fields of a class. Properties are members of a class that provide a flexible mechanism to read, write, or compute the values of private fields. Properties can be used as if they are public data members, but they are actually special methods called accessors. This enables data to be accessed easily and still helps promote the safety and flexibility of methods
    public string Name
    {
        get
        {
            return name.Substring(0,2);
        }
        set
        {
            name = value.ToUpper();
        }
    }

    public bool IsPassed { get => isPassed; set => isPassed = value; }


    #endregion

    // ctrl + r + e to generate properties

    bool isPassed;
    public string Surname { get; set; } = "Doe"; // Auto property initializer
}