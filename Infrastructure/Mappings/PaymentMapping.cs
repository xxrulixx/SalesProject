using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Infrastructure.Mappings
{
    public class PaymentMapping : MappingBase<Payment>
    {
        public PaymentMapping() : base("Payment")
        {
            
            
        }
    }
}
