// console commands
Console.WriteLine("Hi!");
Console.WriteLine("\t Jon is outside");
Console.Write("Okay!");
Console.WriteLine("\nThis is okay");
Console.WriteLine("This is ba\bd");
//Console.Beep();

// datatypes and variables in c#
int x; // declaration
x = 4; // initialisation
x = 5;

double y = 7.4; //declaration + initialisation
char z = '@';
String s = "I am Him";
bool k = false;


Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);
Console.WriteLine(s);
Console.WriteLine("Are you a man?" + k);

// constants
const double pi = 3.142;
Console.WriteLine(pi);

// type casting in c#
// double to integer
double a = 3.55;
int b = Convert.ToInt32(a);
Console.WriteLine(b);
// get data type of a variable
Console.WriteLine(a.GetType());
// int to string
int c = 419;
String d = Convert.ToString(c);
Console.WriteLine(d);

// arithmetic operators : +, -, / , %, *
double school = 5;
//school = school + 2;
//school +=2;
//school++; //increment by 1

//school = school - 2;
//school -= 2;

//school = school / 2;
//school /= 2;

// school = school % 2;
//school = school * 2;
Console.WriteLine(school);

String fullName = "john doe";
String email = "john@doe.com";

Console.WriteLine("Enter your name");
String yourName = Convert.ToString(Console.ReadLine());
Console.WriteLine("Enter your email");
String yourEmail = Convert.ToString(Console.ReadLine());
Console.WriteLine("Enter a password");
String password = Convert.ToString(Console.ReadLine());
Console.WriteLine("Confirm password");
String confirmPassword = Convert.ToString(Console.ReadLine());
if (password.Length < 6 || password.Length > 14)
{
    Console.WriteLine("Password length must not be less than 6 or exceed 14 characters");
}
else if (!password.Any(char.IsUpper))
{
    Console.WriteLine("Password must contain a capital letter");
}
else if (password != confirmPassword)
{
    Console.WriteLine("Passwords do not match");
}
else if(yourName != fullName && yourEmail != email)
{
    Console.WriteLine("Invalid username or email");
}
else
{
    Console.WriteLine("Successful");
}
// int16 -> 99999
// int32 -> 999,999,999
// int64 -> 999,999,999,999, 999, 999


//pythagoras theorem, p^2 = m^2 + n^2
Console.WriteLine("Enter a value for a");
double m = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter a value for b");
double n = Convert.ToDouble(Console.ReadLine());
double p = Math.Sqrt((m * m) + (n * n));
Console.WriteLine("The hypotenuse is " + p);

// = used for assigning a value to a variable or constant
// == used for checking equality

// Conditional statements
if (p == 5)
{
    Console.WriteLine("Congratulations, you are HIM");
}
else if (p == 8)
{
    Console.WriteLine("Congratulations, you are a lucky winner");
}
else
{
    Console.WriteLine("Try again to get a value of 8 or 5");
}

//logical operators
// ==
// > 
// < 
// >= i.e greater than or equal to
// <= i.e less than or equal to
// && i.e AND
// || i.e OR
// ! i.e NOT

// accepting inputs
//Console.WriteLine("What is your name?");
//String name = Console.ReadLine();
//Console.WriteLine("Hello " + name);
//Console.WriteLine("How old are you?");
//int age = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Your name is "+ name + " and you are " + age + " years old");


Console.ReadKey();