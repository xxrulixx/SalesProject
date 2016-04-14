using System.Collections;
using System.Collections.Generic;

namespace Domain
{
    public class Payment : EntityBaseClass
    {
        public int PaymentTypeId { get; private set; }
        public int InvoiceId { get; private set; }
        public float Amount { get; private set; }

        // navigation props
        public IList<PaymentType> PaymentTypes { get; set; }
        public Invoice Invoice { get; set; }

        protected internal Payment()
        {
            
        }
    }
}
