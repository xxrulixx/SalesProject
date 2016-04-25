using System.Collections.Generic;
using Domain;

namespace SalesProject.Events
{
    public class ProductLoadedEvent
    {
        public List<Product> ProductsLoaded { get; private set; }

        public ProductLoadedEvent(List<Product> products)
        {
            ProductsLoaded = products;
        }
}
}