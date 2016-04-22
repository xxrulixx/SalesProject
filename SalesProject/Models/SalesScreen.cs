﻿using System;
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

        public List<Product> VisibleProducts { get; set; } 

        public SalesScreen(ICategoryList categoryList, IProductList productList)
        {
            if (categoryList == null || productList == null)
                throw new ArgumentNullException();

            CategoryList = categoryList;
            ProductList = productList;
        }
        public void InitializeSalesScreen()
        {
            CategoryList.LoadCategories();
            ProductList.LoadProducts();
            VisibleProducts = ProductList.Products;
            
        }

        public void UpdateVisibleProducts()
        {
            var categoryIds = CategoryList.Categories.Where(p => p.Selected).Select(p => p.Id);
            if (categoryIds.Any())
                VisibleProducts = ProductList.Products.FindAll(p => categoryIds.Contains(p.CategoryId));
            else
                VisibleProducts = ProductList.Products.ToList();
        }

        public void ToggleCategory(Category category)
        {
            CategoryList.ToggleSelected(category);
            UpdateVisibleProducts();
        }

       


    }
}
