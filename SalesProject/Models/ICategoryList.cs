using System.Collections.Generic;

namespace SalesProject.Models
{
    public interface ICategoryList
    {
        List<Category> Categories { get; set; }
        void CategoriesLoad();
        void ToggleSelected(Category category);
    }
}