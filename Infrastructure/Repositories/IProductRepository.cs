using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Infrastructure.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetMostAviableProducts(int count);
        IEnumerable<Product> GetTopSellingProducts(int count);
    }
}
