using System;
using System.Collections.Generic;
using System.Globalization;
using ABSTRACT.Entities;
using ABSTRACT.Entities.Enums;

namespace ABSTRACT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            System.Console.Write("Enter the number os shapes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++) 
            {
                System.Console.WriteLine($"Shape #{i} data:");

                System.Console.Write("Rectangle or Circle (r/c)");
                char  ch = char.Parse(Console.ReadLine());

                System.Console.Write("Color (Black/Blue/Red)");

                Color color = Enum.Parse<Color>(Console.ReadLine());


                if(ch == 'r') 
                {
                    System.Console.Write("Width: ");
                    double width = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    System.Console.Write("Height: ");
                    double height = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(width,height, color));
                } 
                else 
                {
                    System.Console.WriteLine("Radius: ");
                    double radius = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
                
            }

            System.Console.WriteLine();
            System.Console.WriteLine("SHAPE AREAS: ");

            foreach(Shape shape in list) 
            {
                System.Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
