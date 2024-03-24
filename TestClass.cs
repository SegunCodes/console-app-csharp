using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    static class TestClass
    {
        public static void division(double a, double b)
        {
            double result = a / b;
            Console.WriteLine(result);
        }

        public static void addition()
        {
            try
            {
                Console.WriteLine("Enter the first number");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                int b = Convert.ToInt32(Console.ReadLine());
                int result = a / b;
                Console.WriteLine(result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You can not divide by zero");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong");
            }
        }

        public static void multiDimensionalArray()
        {
            //String[] greeting = { "Hello", "Hi", "Bonjour", "Buenos Dias" };
            String[,] greetings =
            {
                { "Hello", "Hi" }, { "Bonjour", "Bonsoir" }, { "Buenos Dias", "Buenas noches" }
            };
            greetings[0, 1] = "How far";

            // A loop converts an array into a string
            foreach (string greeting in greetings)
            {
                Console.WriteLine(greeting);
            }
            //Console.WriteLine(greetings[1, 1]);
        }

        public static void matrix()
        {
            int[,,] matrtrix2 =
            {
                { {1,2,3},{4,5,6},{7,8,9} }, //0
                { {9,3,1},{4,2,8},{3,0,4} }, //1
                { {4,4,4},{0,0,0},{1,1,1} }, //2
            };

            Console.WriteLine(matrtrix2[1, 0, 1]);
            foreach (int item in matrtrix2)
            {
                Console.WriteLine(item);
            }
        }

        public static void conditionalOperator(int age)
        {
            string message = (age == 30) ? "Age is okay" : "age is not okay";
            Console.WriteLine(message);
        }

        public static void multiplication(double a, double b)
        {
            double result = a * b;
            Console.WriteLine(result);
        }

        public static void sayHello(int greetingType)
        {
            String[] greeting = { "Hello", "Hi", "Bonjour", "Buenos Dias" };
            if (greetingType == 0)
            {
                Console.WriteLine(greeting[0]);
            }
            if (greetingType == 1)
            {
                Console.WriteLine(greeting[1]);
            }
            if (greetingType == 2)
            {
                Console.WriteLine(greeting[2]);
            }
            else
            {
                Console.WriteLine(greeting[3]);
            }
        }
    }
}
