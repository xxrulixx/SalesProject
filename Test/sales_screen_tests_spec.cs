using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using FluentAssertions;
using Moq;
using Newtonsoft.Json;
using NSpec;
using SalesProject.Models;

namespace Test.Nspec.Debugging
{
    class sales_screen_tests_spec : nspec
    {
        public Mock<ICategoryList> _categoryListMock;
        public Mock<IProductList> _productListMock;
        public List<Product> visibleProducts;  
        public SalesScreen salesScreen;

        private List<Product> _jsonProducts;
        private List<Category> _jsonCategories;


          
        public sales_screen_tests_spec()
        {
            var _jsonProductsStr = System.IO.File.ReadAllText(@"./Resources/products.json");
            var _jsonCategoriesStr = System.IO.File.ReadAllText(@"./Resources/categories.json");
            _jsonProducts = JsonConvert.DeserializeObject<List<Product>>(_jsonProductsStr);
            _jsonCategories = JsonConvert.DeserializeObject<List<Category>>(_jsonCategoriesStr);

            _categoryListMock = new Mock<ICategoryList>();
            _productListMock  = new Mock<IProductList>();

            _productListMock.SetupGet(p => p.Products).Returns(_jsonProducts);
            _categoryListMock.Setup(c => c.LoadCategories());
        }

        void when_creating_it()
        {
            context["when invalid parameters"] = () =>
            {
                it["both parameters null or uninitialized should throw an exception"] = () =>
                {
                    Action action = () => new SalesScreen(null, null);
                    action.ShouldThrow<ArgumentNullException>();
                };

                it["first parameter null or uninitialized should throw an exception"] = () =>
                {
                    Action action = () => new SalesScreen(null, _productListMock.Object);
                    action.ShouldThrow<ArgumentNullException>();
                };

                it["second parameter null or uninitialized should throw an exception"] = () =>
                {
                    Action action = () => new SalesScreen(_categoryListMock.Object, null);
                    action.ShouldThrow<ArgumentNullException>();
                };
            };
        }

        void when_initializing_sales_screen()
        {
            before = () =>
            {
                salesScreen = new SalesScreen(_categoryListMock.Object, _productListMock.Object);
                salesScreen.InitializeSalesScreen();
            };

            it["should call loadcategories from category list"] = () =>
            {
                _categoryListMock.Verify(c => c.LoadCategories(), Times.AtLeastOnce());
            };

            it["should call loadproducts from category list"] = () =>
            {
                _productListMock.Verify(c => c.LoadProducts(), Times.AtLeastOnce());
            };

            it["should set visibleproduct property with the productlist products property"] = () =>
            {
                visibleProducts.should_be(_productListMock.Object.Products);
            };
        }


    }
}
