using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SalesProject
{
    public class CategoryClickedEvent
    {
        public Category Category { get; private set; }

        public CategoryClickedEvent(Category category)
        {
            Category = category;
        }
    }
}
