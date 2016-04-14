using System.Collections.Generic;

namespace SalesProject.Models
{

    

    public interface ICart

    {

        List<Product> CartProducts { get; set; }
        void AddProduct(Product product);
        void RemoveProduct(Product product);
        float Subtotal();

        void CartInitialize();
    }
}