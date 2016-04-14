namespace Infrastructure
{
    class Product : EntityClass
    {
        public string Name { get; private set; }
        public int CategoryId { get; private set; }
        public float Price { get; private set; }
        public int Qty { get; private set; }
        public string Description { get; private set; }
    }
}
