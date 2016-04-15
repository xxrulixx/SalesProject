using System.Data.Entity.ModelConfiguration;
using Domain;

namespace Infrastructure.Mappings
{
    public class PaymentTypeMapping : MappingBase<PaymentType>
    {
        public PaymentTypeMapping() : base("PaymentType")
        {
            HasMany(p => p.Payment)
                .WithRequired()
                .HasForeignKey(p => p.PaymentTypeId);
        }
    }
}
