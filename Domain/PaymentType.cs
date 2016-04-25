using System.Collections.Generic;

namespace Domain
{
    public class PaymentType : EntityBaseClass
    {
        public string Name { get;   set; }

        //navigation prop
        public List<Payment> Payment { get; set; }

        public PaymentType()
        {
            
        }
    }
}
