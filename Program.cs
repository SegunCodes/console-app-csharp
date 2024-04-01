using ConsoleApp;
using System.Collections.Generic;
//Data structure and algorithm : stack, queue, array ,list
// LISTS : List is similar to array but it can increase or decrease dynamically in size.

String[] cars = new String[3];

cars[0] = "Honda";
cars[1] = "Toyota";
cars[2] = "RR";

foreach (var item in cars)
{
    Console.WriteLine(item);
}

// LIST

List<String> phone = new List<string>();
phone.Add("iPhone");
phone.Add("Samsung N20");
phone.Add("Google Pixel");
phone.Add("itel");
//phone.Remove("itel");
phone.Insert(3, "Tecno Phantom");
phone.Sort();
phone.Reverse();
Console.WriteLine(phone.Count());
Console.WriteLine(phone.IndexOf("iPhone"));
//phone.Clear();

foreach (var item in phone)
{
    Console.WriteLine(item);
}

//Console.WriteLine("What is your name");
//string name = Console.ReadLine();
//Console.WriteLine("What is your gender");
//string gender = Console.ReadLine();
Console.WriteLine();
// LIST OF OBJECT
List<User> users = new List<User>();
//users.Add(new User(name,gender));
users.Add(new User("Jon snow", "male"));

foreach (var user in users)
{
    Console.WriteLine(user);
}

Phone phone2 = new Phone("Samsung", "S24");
Console.WriteLine(phone2.brandName);
Console.WriteLine(phone2.nameOfPhone);

Laptop laptop = new Laptop("Macbook Pro");
Console.WriteLine(laptop.model);

//getter and setter
// get - used to return a value
// set - used to assign a value
// you use getters and setters when you want the value of a variable to be assigned to a property or method

//enums is a 'special' class that contains fixed values or constants
Console.WriteLine((int)Planets.Mercury);

//generics : is not specific to a data type.
int[] intArray = { 1, 2, 3, 4 };
double[] doubleArray = { 1.1, 2.22, 3.33, 4.44 };
string[] stringArray = { "a", "b", "c", "d" };

displayData(intArray);
displayData(doubleArray);
displayData(stringArray);

static void displayData<T>(T[] array)
{
    foreach (T item in array)
    {
        Console.WriteLine(item);
    }
}


Console.ReadKey();

class User
{
    public String username;
    public String gender;
    public User(string username, string gender)
    {
        this.username = username;
        this.gender = gender;
    }

    public override string ToString()
    {
        string message = "You are a " + gender + " and your name is " + username;
        return message;
    }
}


class Phone
{
    private String brand;
    private String name;
    public Phone(string brand, string name)
    {
        this.brand = brand;
        this.name = name;
    }

    public string brandName
    {
        get { return brand; }
        set { brand = value; }
    }

    public string nameOfPhone
    {
        get { return name; }
        set { name = value; }
    }

}

class Laptop
{
    public string model { get; set; }
    public Laptop(string model)
    {
        this.model = model;
    }
}

enum Planets
{
    Mercury = 1,
    Venus = 2,
    Earth = 3,
    Mars = 4,
    Jupiter = 5,
    Saturn = 6,
    Uranus = 7,
    Neptune = 8,
    Pluto = 9,
}