using System.Collections.Generic;
using System.Linq;
using Caliburn.Micro;
using Domain;
using SalesProject.Events;
using SalesProject.Models;

namespace SalesProject.ViewModels
{
    public class ShellViewModel : PropertyChangedBase, IHandle<CategoryClickedEvent>, IHandle<ProductClickedEvent>, IHandle<CartProductRemovedEvent>
    {
        private readonly IEventAggregator _events;
        public ISalesScreen MySalesScreen;

        public CategoryListViewModel CategoryListViewModel { get; set; }
        public ProductListViewModel ProductListViewModel { get; set; }
        public CartViewModel CartViewModel { get; set; }

        public ShellViewModel(ISalesScreen mySalesScreen, CategoryListViewModel categoryListViewModel,
                              ProductListViewModel productListViewModel, CartViewModel cartViewModel, IEventAggregator events)
        {
            MySalesScreen = mySalesScreen;
            CategoryListViewModel = categoryListViewModel;
            ProductListViewModel = productListViewModel;
            CartViewModel = cartViewModel;
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
            _events.PublishOnUIThread(new ProductLoadedEvent(MySalesScreen.ProductList.Products));
        }

        public void Handle(CategoryClickedEvent message)
        {
            MySalesScreen.CategoryList.ToggleSelected(message.Category);
            MySalesScreen.UpdateVisibleProducts();
            _events.PublishOnUIThread(new ProductLoadedEvent(MySalesScreen.VisibleProducts));

        }

        public void Handle(ProductClickedEvent message)
        {
            MySalesScreen.Cart.AddProduct(message.ProductClicked);
            UpdateCartView();
        }

        public void Handle(CartProductRemovedEvent message)
        {
            MySalesScreen.Cart.RemoveProduct(message.CartProductRemoved);
            UpdateCartView();
        }

        public void UpdateCartView()
        {
            CartViewModel.CartProducts.Clear();
            CartViewModel.CartProducts.AddRange(MySalesScreen.Cart.CartProducts);
            CartViewModel.Taxes = (float) MySalesScreen.Cart.Taxes(MySalesScreen.GlobalTax);
            CartViewModel.Subtotal = (float) MySalesScreen.Cart.Subtotal(MySalesScreen.GlobalTax);
            CartViewModel.Refresh();
        }
    }

   

}
