using System;
using System.Collections.Generic;
using System.Linq;
using Domain;
using Infrastructure.Repositories;

namespace SalesProject.Models
{
    public class ProductList : IProductList
    {
        private IProductRepository _productRepository;
        public List<Product> Products { get; set; }

        public ProductList(IProductRepository productRepository)
        {
            if (productRepository == null) throw new ArgumentNullException();
            _productRepository = productRepository;
            Products = new List<Product>();
        }

        public void LoadProducts()
        {
            Products = _productRepository.GetAll().ToList();
        }

        public IEnumerable<Product> GetProductsByCategoryId(int categoryId)
        {
            return _productRepository.GetAll().Where(p => p.CategoryId == categoryId);
        }
    }
}
