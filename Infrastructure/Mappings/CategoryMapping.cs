using System;
using System.Data.Entity.ModelConfiguration;
using Domain;

namespace Infrastructure.Mappings
{
    public class CategoryMapping : MappingBase<Category>
    {
        public CategoryMapping() : base("Category")
        {
            
            HasMany(p => p.Products)
                .WithRequired()
                .HasForeignKey(p => p.CategoryId);
        }
    }

}
