using System.Collections.Generic;
using Domain;
using Infrastructure.Repositories;

namespace SalesProject.Models
{
    public interface IProductList
    {
       List<Product> Products { get; set; }
       List<Product> VisibleProducts { get; set; }
       void LoadProducts();
    }
}