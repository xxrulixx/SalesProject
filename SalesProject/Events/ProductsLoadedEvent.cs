using System.Collections.Generic;
using Domain;

namespace SalesProject.Events
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