using System;
using System.Linq;
using System.Windows;
using System.Collections.Generic;

namespace SalesProject.Models
{
    class SalesScreen : ISalesScreen
    {
        public ICart Cart  { get; set; }
        
        public ICategoryList CategoryList { get; private set; }
        public IProductList ProductList { get; private set; }

        public event EventHandler<List<Category>> CategoryListLoaded;
        public event EventHandler<Category> CategoryListItemToggle;
        public event EventHandler<List<Product>> ProductListLoaded;
        public event EventHandler<Product> ProductClicked;

        public List<Product> VisibleProducts { get; set; } 

        public SalesScreen()
        {
            CategoryList = new CategoryList();
            ProductList = new ProductList();
            VisibleProducts = new List<Product>();
            Cart = new Cart();
        }
        public void InitializeSalesScreen()
        {
            CategoryListLoaded += OnCategoryListLoaded;
            CategoryListItemToggle += OnCategoryListItemToggle;

            ProductListLoaded += OnProductListLoaded;

            LoadCategories();
            LoadProducts();
            VisibleProducts = ProductList.Products;
            
            


        }

       
        private void DialogWindow(string s)
        {
            MessageBox.Show($"{s}", "Toy Bolao");
        }

        private void OnCategoryListItemToggle(object sender, Category arg)
        {
            UpdateVisibleProducts();
            DialogWindow($"La categoria que se marco en este momento fue {arg.Name}");
        }

        public void UpdateVisibleProducts()
        {
            var categoryIds = CategoryList.Categories.Where(p => p.Selected).Select(p => p.Id);
            VisibleProducts = ProductList.Products.FindAll(p => categoryIds.Contains(p.CategoryId));
        }

        public void ToggleCategory(Category category)
        {
            if (CategoryList.Categories.Contains(category))
            {
                CategoryList.ToggleSelected(category);
            }
            CategoryListItemToggle?.Invoke(this, category);
        }

        public void LoadCategories()
        {
            CategoryList.CategoriesLoad();
            if (CategoryList.Categories.Any())
                CategoryListLoaded?.Invoke(this, CategoryList.Categories);
        }

        public void LoadProducts()
        {
            ProductList.ProductsLoad();
            
            if (ProductList.Products.Any())
                ProductListLoaded?.Invoke(this,ProductList.Products);
        }


        protected virtual void OnCategoryListLoaded(object sender, List<Category> arg)
        {
            if (arg == null) return;
            DialogWindow($"Categorio Lista: {arg[0].Name}");
        }

        protected virtual void OnProductListLoaded(object sender, List<Product> arg)
        {
            if (arg == null) return;
            DialogWindow($"Producto Lista : {arg[0].Name}");
        }

        protected virtual void OnProductClicked(object sender, Product arg)
        {
            if (arg == null) return;
            Cart.AddProduct(arg);
            DialogWindow($"Se adiciono al carrito el producto:{arg.Name}");
        }
    }
}
