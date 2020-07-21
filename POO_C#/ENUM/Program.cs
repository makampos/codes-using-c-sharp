using System;
using ENUM.Entities;
using ENUM.Entities.Enums;

namespace ENUM
{
    class Program
    {
        static void Main(string[] args)
        {
           Order order = new Order {
               Id= 1080,
               Moment = DateTime.Now,
               Status = OrderStatus.PendingPayment
           };

           System.Console.WriteLine(order);

           string txt = OrderStatus.PendingPayment.ToString();
           System.Console.WriteLine(txt);

           OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

           System.Console.WriteLine(os);
        }
    }
}
