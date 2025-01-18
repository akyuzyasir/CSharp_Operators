
// LOOPS

// A loop is a programming structure that repeats a sequence of instructions until a specific condition is met.

// There are three types of loops in C#; for, while and do-while

#region for loop

// first parameter is the initialization of the loop variable, second parameter is the condition that must be true for the loop to continue, third parameter is the increment or decrement of the loop variable

// in this case we print numbers from 0 to 99 including 0 and 99 but not 100
//for (int i = 0; i < 100; i++)
//{
//    Console.WriteLine(i);
//}

//// this is a infinite loop cause there is no condition to stop the loop
//for (; ; )
//{
//    Console.WriteLine("Ackuse academy");
//}
#endregion

#region while loop

// while loop is used when we don't know the number of iterations in advance. for example we want to read a file until the end of the file is reached. In this case we don't know how many lines the file has. So we cannot use for loop in this case.
//while(true)
//{
//    Console.WriteLine("Ackuse academy");
//}

//bool condition = true;
//int counter = 1;
//while (condition)
//{
//    if (counter <= 100)
//    {
//        Console.WriteLine($"{counter}. Ackuse Academy");
//    }
//    else
//        condition = false;
//    counter++;
//}


#endregion

#region do-while loop

// do-while loop is similar to while loop but the difference is that the condition is checked at the end of the loop. So the loop will run at least once even if the condition is false.

//bool condition = false;
//do
//{
//    Console.WriteLine("Ackuse Academy");
//} while (true);
#endregion

