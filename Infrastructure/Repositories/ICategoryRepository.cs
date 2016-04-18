using System.Collections.Generic;
using Domain;

namespace Infrastructure.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        IEnumerable<Category> GetCategoriesWithProducts();
    }
}
