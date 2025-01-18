


// break, continue and return statements. These are called control statements. They are used to control the flow of the program. 

//

#region break statement

// break statement is used to exit the loop. It is used in loops like for, while and do-while.

// generally we use break statement to exit the loop when a specific condition is met.

//for (int i = 0; i < 100; i++)
//{
//    Console.WriteLine($"{i}-i");
//    if (i == 50)
//    {
//        break;
//    }
//}

#endregion

#region continue statement

// continue statement is used to skip the current iteration of the loop and continue with the next iteration.

// generally we use continue statement to skip the current iteration when a specific condition is met.

//while (true)
//{
//    Console.WriteLine("Enter a number");
//    int number = int.Parse(Console.ReadLine());
//    if (number == 0)
//    {
//        continue;
//    }
//    Console.WriteLine($"You entered {number}");
//}
#endregion

#region return statement

// return statement is used to exit the loop. It is used also used in methods with a return type.

// we use return in loops to exit the loop when a specific condition is met.

//bool condition = true;
//int counter = 1;
//while (condition)
//{
//    if (counter <= 100)
//    {
//        Console.WriteLine($"{counter}. Ackuse Academy");
//    }
//    else
//        return;
//    counter++;
//}

// by this way we can exit the loop without changing the condition to false.

#endregion