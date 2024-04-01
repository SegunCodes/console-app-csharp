using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ArithmeticOperation
    {
        // global variable are like waiters that deliver the food i.e parameters of the constructor
        double a;
        double b;
        // to create a constructor, you will create a function/mode but it will have the name of your class       
        public ArithmeticOperation(double c, double d)
        {
            // assign value
            this.a = c;
            this.b = d;
        }

        public void division()
        {
            double result = a / b;
            Console.WriteLine(result);
        }

        public virtual void addition()
        {
            double result = a + b;
            Console.WriteLine(result);
        }

        public void multiplication()
        {
            double result = a * b;
            Console.WriteLine(result);
        }

        private void subtraction()
        {
            double result = a - b;
            Console.WriteLine(result);
        }
    }
}
