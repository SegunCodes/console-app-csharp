using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Class1 : ArithmeticOperation
    {
        double k;
        double j;
        public Class1(double c, double d) : base(c, d)
        {
            this.k = c;
            this.j = d;
        }

        public void modulus()
        {
            double result = k % j;
            Console.WriteLine(result);
        }

    }
}