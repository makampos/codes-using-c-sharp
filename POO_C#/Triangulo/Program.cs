using System.Globalization;
using System;

namespace Triangle_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            System.Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            System.Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            double areaX = x.Area();

            double areaY = y.Area();

            Console.WriteLine("Área de X = " + areaX);
            Console.WriteLine("Área de Y = " + areaY);
            Console.WriteLine("\n");
            if (areaX > areaY) {

                Console.WriteLine("Maior Área (X):" + areaX);
            }
            else {
                Console.WriteLine("Maior Área (Y):" + areaY);
            }

        }
    }
}
