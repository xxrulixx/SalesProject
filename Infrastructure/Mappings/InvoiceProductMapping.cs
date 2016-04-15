using System.Data.Entity.ModelConfiguration;
using System.Runtime.InteropServices;
using Domain;

namespace Infrastructure.Mappings
{
    public class InvoiceProductMapping : MappingBase<InvoiceProduct>
    {
        public InvoiceProductMapping() : base("InvoiceProduct")
        {
            

        }
    }
}
