using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media.Animation;
using Domain;
using Infrastructure;
using Infrastructure.Mappings;
using Infrastructure.Repositories;

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

        public void ProductsLoad(IProductRepository productRepository)
        {
            Products = productRepository.GetAll().ToList();
        }

    }
}
