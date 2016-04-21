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
        List<Product> VisibleProducts { get; set; }

        void InitializeSalesScreen();

        void UpdateVisibleProducts();

        void ToggleCategory(Category category);

        

    }
}
