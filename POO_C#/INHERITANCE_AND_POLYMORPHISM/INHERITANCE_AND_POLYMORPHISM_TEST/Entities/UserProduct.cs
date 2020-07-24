using System;

namespace INHERITANCE_AND_POLYMORPHISM_TEST.Entities
{
    public class UserProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UserProduct()
        {            
        }

        public UserProduct(string name, double price, DateTime manufacturedDate ) : base ( name, price )
        {
            ManufactureDate = manufacturedDate;
        }
      
        public override string PriceTag() 
        {
            return Name
            +" (used) "
            + " $ "
            + Price
            + "(Manufactured date: "
            + ManufactureDate
            + " ) ";
        }
    }
    
}