using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Domain;

namespace SalesProject.Models
{
    public interface ISalesScreen
    {
        ICategoryList CategoryList { get; }
        IProductList ProductList { get; }
        ICart Cart { get; set; }

        event EventHandler<List<Category>> CategoryListLoaded;
        event EventHandler<Category> CategoryListItemToggle;
        event EventHandler<List<Product>> ProductListLoaded;
        event EventHandler<Product> ProductClicked;

        void InitializeSalesScreen();

        void LoadCategories();
        void LoadProducts();

        void UpdateVisibleProducts();

        void ToggleCategory(Category category);

        

    }
}
