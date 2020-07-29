using System;
using contrato.Model.Entities;
using contrato.Model.Entities.Enum;

namespace contrato
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle()  { Radius = 2.0, Color = Color.white };
            IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.black} ;

            System.Console.WriteLine(s1);
            System.Console.WriteLine(s2); 
        }
    }
}
