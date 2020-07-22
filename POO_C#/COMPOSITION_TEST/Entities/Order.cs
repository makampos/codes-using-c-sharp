using System;
using System.Collections.Generic;
using COMPOSITION_TEST.Entities.Enum;

namespace COMPOSITION_TEST.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set;}
         public List<OrderItem> items { get; set;} = new List<OrderItem>();
        public Order()
        {            
        }
        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;           
        }
   
        public void AddItem(OrderItem item) 
        {
            items.Add(item);
        }

        public void RemoveItem(OrderItem item) 
        {
            items.Remove(item);
        }

        public double Total() 
        {
            double sum = 0.0;
            foreach(OrderItem item in items) 
            {
                sum += item.SubTotal();
            }
            return sum  ;
        }
       

    }
}