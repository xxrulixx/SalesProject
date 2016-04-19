using System.Collections.Generic;
using Domain;
using Infrastructure.Repositories;

namespace SalesProject.Models
{
    public interface ICategoryList
    {
        List<Category> Categories { get; set; }
        void LoadCategories();
        void ToggleSelected(Category category);
    }
}