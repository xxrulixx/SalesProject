using System.Collections.Generic;
using System.Linq;

namespace SalesProject.Models
{
    public class ProductList : IProductList
    {
        public List<Product> Products { get; set; }
        public List<Product> VisibleProducts { get; set; }

        public ProductList()
        {
            Products = new List<Product>();
        }

        public void ProductsLoad()
        {
            try
            {
                Products = Fixtures.GetProducts().ToList();
            }
            catch
            {
                // ignored
            }

            //ProductsLoaded?.Invoke(this, args);
        }

    }
}
