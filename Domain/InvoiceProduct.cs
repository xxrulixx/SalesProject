namespace Domain
{
    public class InvoiceProduct
    {
        public int InvoiceId { get; private set; }
        public int ProductId { get; private set; }
        public string ProductName { get; private set; }
        public string ProductDescription { get; private set; }
        public int CategoryId { get; private set; }
        public string CategoryName { get; private set; }
        public int Qty { get; private set; }
        public float Price { get; private set; }
        public float Tax { get; private set; }

        //navigation
        public Invoice Invoice { get; set; }

        protected internal InvoiceProduct()
        {
            
        }
    }
}
