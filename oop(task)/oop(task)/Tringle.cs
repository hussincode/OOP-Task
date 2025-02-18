using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_task_
{
    //___Tringle class___
    class Tringle : Shape
    {
        //___Perimeter of Tringle___
        public double side1;
        public double side2;
        public double side3;
        public override void Perimeter()
        {
            double perimeter = side1 + side2 + side3;
            Console.WriteLine("Perimeter of Tringle is: " + perimeter);
        }

        //___Area of Tringle___

        public double height;
        public double besa;
        public override void Area()
        {
            double area = 0.5 * (height * besa);
            Console.WriteLine("Area of Tringle is: " + area);
        }
    }
}
