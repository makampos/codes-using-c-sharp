using System.Collections.Generic;

namespace INHERITANCE_AND_POLYMORPHISM_TEST.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        

        public Product()
        {   
        }

        public Product(string name, double price) 
        {
            Name = name;
            Price = price;
        }

        public  virtual string  PriceTag(string pricetag)
        {
           return  pricetag;
        }
    }
}