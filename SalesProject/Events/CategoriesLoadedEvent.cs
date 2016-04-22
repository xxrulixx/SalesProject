using System.Collections.Generic;
using Domain;

namespace SalesProject.Events
{
    public class CategoriesLoadedEvent
    {
        public List<Category> CategoriesLoaded { get; set; }

        public CategoriesLoadedEvent(List<Category> categories)
        {
            CategoriesLoaded = categories;
        }
    }
}