using System;
using System.Collections.Generic;
using INHERITANCE_AND_POLYMORPHISM_TEST.Entities;

namespace INHERITANCE_AND_POLYMORPHISM_TEST
{
    class Program
    {
        static void Main(string[] args)
        {
             List<Product> products = new List<Product>();
            
            System.Console.Write("Enter the number of products: ");
            int number = int.Parse(Console.ReadLine());

            for(int i = 1; i <= number; i++) {
                System.Console.WriteLine($"Product #{i} data:");
                System.Console.Write("Common, used or imported (c/u/i)? :");
                char type = Char.Parse(Console.ReadLine());

                System.Console.Write("Name ");
                string name = Console.ReadLine();
                System.Console.Write("Price ");
                double price = Double.Parse(Console.ReadLine());

                if(type == 'i')
                {
                    System.Console.Write("Customs fee ");
                    double customsFee = Double.Parse(Console.ReadLine());
                    products.Add( new ImportedProduct(name, price,customsFee));  
                } 
                else if (type == 'u'){
                    System.Console.Write("Manufactured date (DD/MM/YYYY): ");
                    DateTime manufacturedDate = DateTime.Parse(Console.ReadLine());
                    products.Add(new UserProduct(name,price,manufacturedDate)); 
                }                
                 else {
                    products.Add(new Product(name, price));
                 }

            }
        }
    }
}
