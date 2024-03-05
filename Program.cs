//switch statement
Console.WriteLine("Input a car name");
String name = Console.ReadLine();

switch (name)
{
    case "Honda":
        Console.WriteLine(name + " is a car");
        break;
    case "Chevrolet":
        Console.WriteLine(name + " is a car");
        break;
    case "Lexus":
        Console.WriteLine(name + " is a car");
        break;
    case "Rolls Royce":
        Console.WriteLine(name + " is a car");
        break;
    case "Benz":
        Console.WriteLine(name + " is a car");
        break;
    default:
        Console.WriteLine(name + " is not  a car");
        break;


}

Console.ReadKey();