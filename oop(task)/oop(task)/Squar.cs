using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_task_
{
    //___Squar class___

    class Squar : Shape
    {
        //___Area of Squar___

        public double side;
        public override void Area()
        {
            double area = side * side;
            Console.WriteLine("Area of Squar is: " + area);
        }

        //___Perimeter of Squar___

        public override void Perimeter()
        {
            double perimeter = 4 * side;
            Console.WriteLine("Perimeter of Squar is: " + perimeter);
        }
    }
}
