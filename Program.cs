// console commands
using System.Reflection.Metadata;

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

Console.ReadLine();