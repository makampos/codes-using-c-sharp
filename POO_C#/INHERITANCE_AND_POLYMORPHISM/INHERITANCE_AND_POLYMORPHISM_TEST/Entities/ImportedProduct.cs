namespace INHERITANCE_AND_POLYMORPHISM_TEST.Entities
{
    public class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }


        public ImportedProduct()
        {            
        }
        
        public ImportedProduct(string name, double price, double customsFee) : base (name, price)
        {
            CustomsFee = customsFee;
        }

        

    }
}