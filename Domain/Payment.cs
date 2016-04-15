using System.Collections;
using System.Collections.Generic;

namespace Domain
{
    public class Payment : EntityBaseClass
    {
        public int PaymentTypeId { get;   set; }
        public int InvoiceId { get;   set; }
        public float Amount { get;   set; }

        // navigation props
        public IList<PaymentType> PaymentTypes { get; set; }
        public Invoice Invoice { get; set; }

        protected internal Payment()
        {
            
        }
    }
}
