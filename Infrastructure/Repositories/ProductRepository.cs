using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Infrastructure.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository 
    {
        public ProductRepository(SalesContext context) : base(context)
        {
            
        }

        public IEnumerable<Product> GetMostAviableProducts(int count)
        {
            return SalesContext.Products.OrderByDescending(p => p.Qty).Take(count).ToList();
        }

        public IEnumerable<Product> GetTopSellingProducts(int count)
        {
            return SalesContext.Products.OrderByDescending(p => p.Price).Take(count).ToList();
        }

        public SalesContext SalesContext
        {
            get
            {
                return Context as SalesContext;
            }
        }
    }
}
