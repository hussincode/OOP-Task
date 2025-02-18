using System;
using oop_task_;

class Program
{
    static void Main()
    {
        //___Circle___

        Console.WriteLine("***Circle***");
        Circle c = new Circle();
        c.radius = 5;
        c.Area();
        c.Perimeter();

        //___Tringle___

        Console.WriteLine();
        Console.WriteLine("***Tringle***");
        Tringle t = new Tringle();
        t.side1 = 3;
        t.side2 = 4;
        t.side3 = 5;
        t.height = 4;
        t.besa = 3;
        t.Area();
        t.Perimeter();

        //___Squar___

        Console.WriteLine();
        Console.WriteLine("***Squar***");
        Squar s = new Squar();
        s.side = 4;
        s.Area();
        s.Perimeter();

        //___Rectangle___

        Console.WriteLine();
        Console.WriteLine("***Rectangle***");
        Rectangle r = new Rectangle();
        r.Length = 5;
        r.Width = 4;
        r.Area();
        r.Perimeter();
    }
}