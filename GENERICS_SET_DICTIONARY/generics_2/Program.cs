using System;
using System.Collections.Generic;
using System.Globalization;
using generics_2.Entities;
using generics_2.Services;

namespace generics_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            System.Console.WriteLine("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) 
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);                
                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list);

            System.Console.Write("Max: ");
            System.Console.Write(max);
            System.Console.WriteLine();
        }
    }
}
