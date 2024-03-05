//switch statement
using System;

// while loop : The while loop is used to repeat a section of code an "unknown" number of times until a specific condition is met
// String name = "";
// while (name == "")
// {
// Console.WriteLine("Input a car name");
// name = Console.ReadLine();
// }

// For loop : "For" Loop is used to repeat a specific block of code a "known" number of times
// list all natural numbers using a for loop
// for (int i = 0; i < 10; i+=2)
// {
// Console.WriteLine(i);
// }

// nested loops is a loop inside a loop
Console.WriteLine("How many rows?");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many columns?");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter an alphabet");
String alphabet = Console.ReadLine();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(alphabet); 
    }
    Console.WriteLine();
}


Console.ReadKey();