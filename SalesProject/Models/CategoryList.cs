using System.Collections.Generic;
using System.Linq;
using Domain;
using Infrastructure.Repositories;

namespace SalesProject.Models
{
    public class CategoryList : ICategoryList
    {

        public List<Category> Categories { get; set; }

        public CategoryList()
        {
             Categories = new List<Category>();
        }


        /// <summary>
        /// Load Categories from somewhere
        /// </summary>
        public void CategoriesLoad(ICategoryRepository categoryRepository)
        {
            Categories = categoryRepository.GetAll().ToList();
        }

        public void ToggleSelected(Category category)
        {
            if (Categories.Contains(category))
            {
                category.Selected = !category.Selected;
            }
            //else
            //    throw NotFound();
        }


        public void ToggleCategorySelect(Category category)
        {
            category.Selected = !category.Selected;
           
        }

    }

    
}
