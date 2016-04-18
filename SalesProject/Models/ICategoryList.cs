using System.Collections.Generic;
using Domain;
using Infrastructure.Repositories;

namespace SalesProject.Models
{
    public interface ICategoryList
    {
        List<Category> Categories { get; set; }
        void CategoriesLoad(ICategoryRepository categoryRepository);
        void ToggleSelected(Category category);
    }
}