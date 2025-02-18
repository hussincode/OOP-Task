using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_task_
{
    //___Circle class___

    class Circle : Shape
    {
        //___Area of Circle___

        private const double PI = 3.14159265359;
        public double radius;
        public override void Area()
        {
        double area = PI * radius * radius;
        Console.WriteLine("Area of Circle is: " + area);
        }

        //___Perimeter of Circle___

        public override void Perimeter()
        {
            double perimeter = 2 * PI * radius;
            Console.WriteLine("Perimeter of Circle is: " + perimeter);
        }

    }
}
