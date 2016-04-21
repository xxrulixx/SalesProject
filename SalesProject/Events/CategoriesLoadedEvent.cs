using System.Collections.Generic;
using Domain;

namespace SalesProject.ViewModels
{
    public class CategoriesLoadedEvent
    {
        public List<Category> CategoriesLoaded { get; private set; }

        public CategoriesLoadedEvent(List<Category> categories)
        {
            CategoriesLoaded = categories;
        }
    }
}