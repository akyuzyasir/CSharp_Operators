
// There are three types of errors in C#; compile-time errors, runtime errors and logical errors.

// Compile-time errors are errors that occur during the compilation of the program. These errors are caused by syntax errors, type errors, or other errors that prevent the program from compiling. We can easily identify these errors because the compiler will show an error message with the line number and the type of error.

// Logical errors are errors that occur when the program runs but does not produce the expected output. These errors are caused by incorrect logic in the program. For example, if we write a program to calculate the sum of two numbers but we use the subtraction operator instead of the addition operator, the program will run but will produce the wrong output.

// Runtime errors are errors that occur when the program is running. These errors are caused by exceptions that are thrown during the execution of the program. For example, if we try to divide a number by zero, the program will throw a DivideByZeroException at runtime.

// To handle runtime errors, we use try-catch blocks. A try-catch block is used to catch exceptions that are thrown during the execution of the program. The try block contains the code that may throw an exception, and the catch block contains the code that handles the exception.

try
{
    Console.WriteLine("Please enter a number");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(number + " is the input");
}
catch (Exception)
{
    Console.WriteLine("False input");
	throw;
}

try
{
    Console.WriteLine("Please enter a number");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(number + " is the input");
}
catch (Exception ex) when (ex.Source == "mscorlib")
{
    Console.WriteLine(ex.Message);
}

Console.Read();