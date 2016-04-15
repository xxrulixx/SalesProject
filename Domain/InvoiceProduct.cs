using System.Collections.Generic;

namespace Domain
{
    public class InvoiceProduct : EntityBaseClass
    {
        public int InvoiceId { get;   set; }
        public int ProductId { get;   set; }
        public string ProductName { get;   set; }
        public string ProductDescription { get;   set; }
        public int CategoryId { get;   set; }
        public string CategoryName { get;   set; }
        public int Qty { get;   set; }
        public float Price { get;   set; }
        public float Tax { get;   set; }

        //navigation
        public List<Invoice> Invoices { get; set; }
        public List<Product> Products { get; set; }

        protected internal InvoiceProduct()
        {
            
        }
    }
}
