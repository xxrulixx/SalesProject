using System;
using System.Windows.Controls.Primitives;
using Caliburn.Micro;
using Domain;
using SalesProject.Models;

namespace SalesProject.ViewModels
{
    public class ShellViewModel : PropertyChangedBase
    {
        protected ISalesScreen MySalesScreen;

        public BindableCollection<Category> Categories { get; set; }
        public BindableCollection<Product> Products { get; set; }

        public void ToggleCategory(object sender, EventArgs e)
        {
            var button = (ToggleButton)sender;
            var category = (Category)button.DataContext;
            MySalesScreen.ToggleCategory(category);
        }

        public ShellViewModel(ISalesScreen mySalesScreen)
        {

            MySalesScreen = mySalesScreen;
            //MySalesScreen = DependencyInjector.Container.GetInstance<ISalesScreen>();

            MySalesScreen.CategoryListLoaded += (sender, list) =>
            {
                Categories = new BindableCollection<Category>(list);
                NotifyOfPropertyChange(() => Categories);
              
            };
            
            MySalesScreen.ProductListLoaded += (sender, list) =>
            {
                Products = new BindableCollection<Product>(list);
                NotifyOfPropertyChange(() => Products);
            };

            


            MySalesScreen.InitializeSalesScreen();
            
        }


        #region Actions

        public void CategoryClicked(Category category)
        {
            MySalesScreen.CategoryList.ToggleSelected(category);
        }


        #endregion

    }

   

}
