using System.Collections.Generic;
using System.Linq;
using Caliburn.Micro;
using Domain;
using SalesProject.Events;
using SalesProject.Models;

namespace SalesProject.ViewModels
{
    public class ShellViewModel : PropertyChangedBase, IHandle<CategoryClickedEvent>
    {
        private readonly IEventAggregator _events;
        public ISalesScreen MySalesScreen;

        public CategoryListViewModel CategoryListViewModel { get; set; }
        public ProductListViewModel ProductListViewModel { get; set; }
        

        public ShellViewModel(ISalesScreen mySalesScreen, CategoryListViewModel categoryListViewModel,
                              ProductListViewModel productListViewModel, IEventAggregator events)
        {
            MySalesScreen = mySalesScreen;
            CategoryListViewModel = categoryListViewModel;
            ProductListViewModel = productListViewModel;

            _events = events;

            MySalesScreen.InitializeSalesScreen();
            LoadCategories();
            LoadProducts();

            events.Subscribe(this);
        }

        private void LoadCategories()
        {
            MySalesScreen.CategoryList.LoadCategories();
            _events.PublishOnUIThread(new CategoriesLoadedEvent(MySalesScreen.CategoryList.Categories));
        }

        private void LoadProducts()
        {
            MySalesScreen.ProductList.LoadProducts();
            _events.PublishOnUIThread(new ProductsLoadedEvent(MySalesScreen.ProductList.Products));
        }

        public void Handle(CategoryClickedEvent message)
        {
            MySalesScreen.CategoryList.ToggleSelected(message.Category);
            MySalesScreen.UpdateVisibleProducts();
            _events.PublishOnUIThread(new ProductsLoadedEvent(MySalesScreen.VisibleProducts));

        }
    }

   

}
