using System.Data.Entity.ModelConfiguration;
using Domain;

namespace Infrastructure.Mappings
{
    public class MappingBase<T> : EntityTypeConfiguration<T> where T : EntityBaseClass
    {

        public MappingBase(string tableName)
        {
            ToTable(tableName);
            HasKey(p => p.Id);
            
            
            
        }

    }
}
