using System.Data.Entity.ModelConfiguration;
using Domain;

namespace Infrastructure.Mappings
{
    public class InvoiceMapping : MappingBase<Invoice>
    {
        public InvoiceMapping() : base("Invoice")
        {
            HasMany(p => p.Payments)
                .WithRequired()
                .HasForeignKey(p => p.InvoiceId);
        }
    }
}
