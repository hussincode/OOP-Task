using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace oop_task_
{
    //___Rectangle class___
    class Rectangle : Shape
    {

        //___Area of Rectangle___

        public double Length;
        public double Width;
        public override void Area()
        {
            double area = Length * Width;
            Console.WriteLine("Area of Rectangle is: " + area);
        }


        //___Perimeter of Rectangle___

        public override void Perimeter()
        {
            double perimeter = 2 * (Length + Width);
            Console.WriteLine("Perimeter of Rectangle is: " + perimeter);
        }

    }
}
