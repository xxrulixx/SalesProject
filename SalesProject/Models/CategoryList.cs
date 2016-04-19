using System.Collections.Generic;
using System.Linq;
using Domain;
using Infrastructure.Repositories;

namespace SalesProject.Models
{
    public class CategoryList : ICategoryList
    {
        private readonly ICategoryRepository _categoryRepository;

        public List<Category> Categories { get; set; }

        public CategoryList(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            Categories = new List<Category>();
        }


        /// <summary>
        /// Load Categories from somewhere
        /// </summary>
        public void LoadCategories()
        { 
            Categories = _categoryRepository.GetAll().ToList();
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
