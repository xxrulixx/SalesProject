using System.Collections.Generic;

namespace SalesProject.Models
{
    public interface IProductList
    {
       List<Product> Products { get; set; }
       List<Product> VisibleProducts { get; set; }
       void ProductsLoad();
    }
}