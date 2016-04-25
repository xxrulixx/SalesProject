using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SalesProject.Events
{
    public class CartProductRemovedEvent
    {
        public Product CartProductRemoved { get; private set; }

        public CartProductRemovedEvent(Product product)
        {
            CartProductRemoved = product;
        }

    }
}
