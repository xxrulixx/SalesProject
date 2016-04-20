using System;
using System.Linq;
using System.Windows;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics.Eventing.Reader;
using Domain;
using Infrastructure.Repositories;

namespace SalesProject.Models
{
    public class SalesScreen : ISalesScreen
    {
        private ICategoryRepository _categoryRepository;
        private IProductRepository _productRepository;

        public ICart Cart  { get; set; }
        
        public ICategoryList CategoryList { get;  set; }
        public IProductList ProductList { get;  set; }

        public event EventHandler<List<Category>> CategoryListLoaded;
        public event EventHandler<Category> CategoryListItemToggle;
        public event EventHandler<List<Product>> ProductListLoaded;
        public event EventHandler<Product> ProductClicked;

        public List<Product> VisibleProducts { get; set; } 

        public SalesScreen(ICategoryList categoryList, IProductList productList)
        {
            CategoryList = categoryList;
            ProductList = productList;

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
            if (categoryIds.Any())
                VisibleProducts = ProductList.Products.FindAll(p => categoryIds.Contains(p.CategoryId));
            else
                VisibleProducts = ProductList.Products.ToList();
              
            ProductListLoaded?.Invoke(this, VisibleProducts);
        }

        public void ToggleCategory(Category category)
        {
            CategoryList.ToggleSelected(category);
            UpdateVisibleProducts();
        }

        public void LoadCategories()
        {
            CategoryList.LoadCategories();
            
            if (CategoryList.Categories.Any())
                CategoryListLoaded?.Invoke(this, CategoryList.Categories);
        }

        public void LoadProducts()
        {
            ProductList.LoadProducts();
            if (ProductList.Products.Any())
                ProductListLoaded?.Invoke(this,ProductList.Products);
        }


    }
}
