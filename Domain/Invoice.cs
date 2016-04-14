using System;
using System.Collections.Generic;

namespace Domain
{
    public class Invoice : EntityBaseClass
    {
        public DateTime TimeStamp { get; private set; }
        public float    Subtotal { get; private set; }
        public float Tax { get; private set; }
        public float Total { get; private set; }

        // navigation
        public IList<Payment> Payments { get; set; }
        public IList<InvoiceProduct> InvoiceProducts { get; set; }


        protected internal Invoice()
        {
            
        }
    }
}
