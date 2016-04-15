namespace Domain
{
    public class Product : EntityBaseClass
    {
        public string Name { get;   set; }
        public int CategoryId { get;   set; }
        public float Price { get;   set; }
        public int Qty { get;   set; }
        public string Description { get; set; }

        //Navigation Property
        public Category Category { get; set; }

        protected internal Product()
        {
            
        }
    }
}
