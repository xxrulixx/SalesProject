using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
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
            if (categoryRepository == null)
                throw new ArgumentNullException();
            
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
            if (category == null)
                throw new ArgumentNullException();

            if (!Categories.Contains(category))
                throw new ObjectNotFoundException();

            category.Selected = !category.Selected;
        }


        public void ToggleCategorySelect(Category category)
        {
            category.Selected = !category.Selected;
           
        }

    }

    
}
