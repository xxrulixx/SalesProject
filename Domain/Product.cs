namespace Domain
{
    public class Product : EntityBaseClass
    {
        public string Name { get;   set; }
        public int CategoryId { get;   set; }
        public float Price { get;   set; }
        public int Qty { get;   set; }
        public float Tax { get; set; }
        public string Description { get; set; }

        //Navigation Property
        public Category Category { get; set; }

        public Product()
        {
            
        }

        public Product Clone()
        {
            return new Product()
            {
                Id = Id,
                Name = Name,
                Qty = 0,
                Price = Price
            };
        }
    }
}
