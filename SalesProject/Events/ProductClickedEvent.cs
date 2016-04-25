using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesProject.Events
{
    public class ProductClickedEvent
    {
        public  Product ProductClicked { get; private set; }

        public ProductClickedEvent(Product product)
        {
            ProductClicked = product;
        }
    }
}
