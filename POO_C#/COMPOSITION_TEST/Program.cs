using System;
using System.Globalization;
using COMPOSITION_TEST.Entities;
using COMPOSITION_TEST.Entities.Enum;

namespace COMPOSITION_TEST
{
    class Program
    {
        static void Main(string[] args)
        {
           System.Console.WriteLine("Enter client data");
           System.Console.WriteLine("-----------------");

           Console.Write("Name: ");
           string name = Console.ReadLine();   

           Console.Write("Email: ");
           string email = Console.ReadLine();

            System.Console.Write("Birth date: (DD/MM/YYYY)");
           DateTime birthDate = DateTime.Parse(Console.ReadLine());        

           System.Console.WriteLine("Enter order data");
           System.Console.Write("Status: ");
           OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

           Client client = new Client(name, email, birthDate);
           Order order = new Order( DateTime.Now, status, client);
            

            System.Console.Write("How Many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i ++) 
            {
                System.Console.WriteLine($"Enter #{i} item data:");
                System.Console.Write("Product name: ");
                string productName = Console.ReadLine();

                System.Console.Write("Product price: ");
                double productPrice = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                System.Console.Write("Quantity: ");
                int quantityProduct = int.Parse(Console.ReadLine());

                
                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(quantityProduct, productPrice, product);

                order.AddItem(orderItem);
                
            }

            System.Console.WriteLine("ORDER SUMMARY:");
            System.Console.WriteLine(order);
             
            

                            
        }
    }
}
