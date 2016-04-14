using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void CategoriesLoad()
        {
            try
            {
                Categories = Fixtures.GetCategories().ToList();
            }
            catch (Exception e)
            {

            }    
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


        public IEnumerator<Category> GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    
}
