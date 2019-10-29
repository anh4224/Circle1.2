using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            Console.WriteLine("The circle has radius of {0} and area of {1} and Circumference {2}",
                c1.getRadius(), c1.getArea(), c1.getCircumference());
            Circle c2 = new Circle(2);
            Console.WriteLine("The circle has radius of {0} and area of {1} and Circumference {2}",
                c2.getRadius(), c2.getArea(), c2.getCircumference());

        }
    }
}
