using System;
using System.Collections.Generic;
using System.Linq;
using Domain;

namespace SalesProject.Models
{
    public class Cart : ICart
    {
        private List<Product> _cartProducts;

        public List<Product> CartProducts
        {
            get { return _cartProducts; }
            set
            {
                _cartProducts = CartProducts;
            }
        }
        public Invoice CartInvoice;

        public void AddProduct(Product product)
        {
            var cartProduct = CartProducts.FirstOrDefault(p => p.Id == product.Id);
            if (cartProduct == null)
            {
                cartProduct = product.Clone();
                CartProducts.Add(cartProduct);
            }
            cartProduct.Qty++;
        }

        public void RemoveProduct(Product product)
        {
            if(product == null)
                throw new ArgumentNullException();
            var cartProduct = CartProducts.FirstOrDefault(p => p.Id == product.Id);
            if (cartProduct != null)
            {
                if (cartProduct.Qty > 1)
                    cartProduct.Qty--;
                else
                {
                    CartProducts.Remove(cartProduct);
                }
            }
            
        }

        public float Subtotal()
        {
            return CartProducts.Sum(p => p.Price);
        }

        public Cart()
        {
            _cartProducts = new List<Product>();

        }
    }
}
