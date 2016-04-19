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
        private IProductRepository _productRepository;
        public List<Product> Products { get; set; }
        public List<Product> VisibleProducts { get; set; }

        public ProductList(IProductRepository productRepository)
        {
            _productRepository = productRepository;
            Products = new List<Product>();
        }

        public void LoadProducts()
        {
            Products = _productRepository.GetAll().ToList();
        }

    }
}
