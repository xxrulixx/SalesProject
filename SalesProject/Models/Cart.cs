using System.Collections.Generic;
using System.Linq;
using Domain;

namespace SalesProject.Models
{
    public class Cart : ICart
    {
        public List<Product> CartProducts { get; set; }
        
        public void AddProduct(Product product)
        {
            CartProducts.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            CartProducts.Remove(product);
        }

        public float Subtotal()
        {
            return CartProducts.Sum(p => p.Price);
        }

        public Cart()
        {
            CartProducts = new List<Product>();

        }
        public void CartInitialize()
        {

        }
    }
}
