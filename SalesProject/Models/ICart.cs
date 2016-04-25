using System.Collections.Generic;
using Domain;

namespace SalesProject.Models
{
    public interface ICart
    {
        List<Product> CartProducts { get; set; }
        void AddProduct(Product product);
        void RemoveProduct(Product product);
        double Taxes(double taxRate);
        double Subtotal(double taxRate);
    }
}