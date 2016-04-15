using System.Data.Entity.ModelConfiguration;
using Domain;

namespace Infrastructure.Mappings
{
    public class ProductMapping : MappingBase<Product>
    {
        public ProductMapping() : base("Product")
        {
            
        }

    }
}
