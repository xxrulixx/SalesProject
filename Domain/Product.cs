namespace Domain
{
    public class Product : EntityBaseClass
    {
        public string Name { get; private set; }
        public int CategoryId { get; private set; }
        public float Price { get; private set; }
        public int Qty { get; private set; }
        public string Description { get; private set; }

        //Navigation Property
        public Category Category { get; set; }

        protected internal Product()
        {
            
        }
    }
}
