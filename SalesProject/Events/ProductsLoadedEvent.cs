using System.Collections.Generic;
using Domain;

namespace SalesProject.ViewModels
{
    public class ProductsLoadedEvent
    {
        public List<Product> ProductsLoaded { get; private set; }

        public ProductsLoadedEvent(List<Product> products)
        {
            ProductsLoaded = products;
        }
}
}