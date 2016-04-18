using System;
using System.Linq;
using System.Windows;
using System.Collections.Generic;
using System.Data.Entity;
using Domain;
using Infrastructure.Repositories;

namespace SalesProject.Models
{
    public class SalesScreen : ISalesScreen
    {
        private ICategoryRepository _categoryRepository;
        private IProductRepository _productRepository;

        public ICart Cart  { get; set; }
        
        public ICategoryList CategoryList { get; private set; }
        public IProductList ProductList { get; private set; }

        public event EventHandler<List<Category>> CategoryListLoaded;
        public event EventHandler<Category> CategoryListItemToggle;
        public event EventHandler<List<Product>> ProductListLoaded;
        public event EventHandler<Product> ProductClicked;

        public List<Product> VisibleProducts { get; set; } 

        public SalesScreen(ICategoryRepository categoryRepository, IProductRepository productRepository)
        {
            CategoryList = new CategoryList();
            ProductList  = new ProductList();
            _categoryRepository = categoryRepository;
            _productRepository  = productRepository;

        }
        public void InitializeSalesScreen()
        {
            LoadCategories();
            LoadProducts();
            VisibleProducts = ProductList.Products;
        }

        public void UpdateVisibleProducts()
        {
            var categoryIds = CategoryList.Categories.Where(p => p.Selected).Select(p => p.Id);
            VisibleProducts = ProductList.Products.FindAll(p => categoryIds.Contains(p.CategoryId));
            ProductListLoaded?.Invoke(this, VisibleProducts);
        }

        public void ToggleCategory(Category category)
        {
            CategoryList.ToggleSelected(category);
            UpdateVisibleProducts();

            
        }

        public void LoadCategories()
        {
            CategoryList.Categories = _categoryRepository.GetAll().ToList();
            if (CategoryList.Categories.Any())
                CategoryListLoaded?.Invoke(this, CategoryList.Categories);
        }

        public void LoadProducts()
        {
            ProductList.Products = _productRepository.GetAll().ToList();
            if (ProductList.Products.Any())
                ProductListLoaded?.Invoke(this,ProductList.Products);
        }


    }
}
