using System;
using System.Collections.Generic;

namespace Domain
{
    public class Invoice : EntityBaseClass
    {
        public DateTime TimeStamp { get;   set; }
        public float  Subtotal { get;   set; }
        public float Tax { get;   set; }
        public float Total { get;   set; }

        // navigation
        public IList<Payment> Payments { get; set; }
        public IList<InvoiceProduct> InvoiceProducts { get; set; }


        protected internal Invoice()
        {
            
        }
    }
}
