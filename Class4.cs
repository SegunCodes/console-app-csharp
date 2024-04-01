using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Class4 : Class3
    {
        public override void students()
        {
            Console.WriteLine("The student is here");
        }

        public override void student(int id)
        {
            Console.WriteLine("The student with id number " + id + "  is here");
        }
    }
}
