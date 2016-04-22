using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using FluentAssertions;
using Infrastructure.Repositories;
using Moq;
using Newtonsoft.Json;
using NSpec;
using SalesProject.Models;

namespace Test.Nspec.Debugging
{
    class product_list_tests_spec : nspec
    {
        public Mock<IProductRepository> _productRepositoryMock;
        public ProductList productList;
        public List<Product> products;

        private List<Product> _jsonProducts;
        private IEnumerable<Product> products_cat_one;

        public product_list_tests_spec()
        {
            var jsonString = System.IO.File.ReadAllText(@"./Resources/products.json");
            _jsonProducts = JsonConvert.DeserializeObject<List<Product>>(jsonString);
            _productRepositoryMock = new Mock<IProductRepository>();

            _productRepositoryMock.Setup(p => p.GetAll()).Returns(_jsonProducts);
            
        }

        void when_creating_it()
        {
            context["with invalid parameters"] = () =>
            {
                it["should not allow a null product list repository"] = () =>
                {
                    Action action = () => new ProductList(null);
                    action.ShouldThrow<ArgumentNullException>();
                };
            };

            context["with valid parameters"] = () =>
            {
                it["should initialize product list"] = () =>
                {
                    productList = new ProductList(_productRepositoryMock.Object);
                    productList.Products.should_not_be(null);
                };

            };
        }

        void when_loading_products()
        {
            before = () =>
            {
                productList = new ProductList(_productRepositoryMock.Object);
                productList.LoadProducts();
            };

            it["should call GetAll method from product list repository"] = () =>
            {
                _productRepositoryMock.Verify(p => p.GetAll(), Times.Once());
            };

            it["should set the Products property with the result from Product Repository"] = () =>
            {
                productList.Products.should_be(_jsonProducts);
            };
        }

        void when_getting_products_by_category_id()
        {
            before = () =>
            {
                productList = new ProductList(_productRepositoryMock.Object);
                products_cat_one = new List<Product>(_jsonProducts.Where(p => p.CategoryId == 1));
            };

            it["should return products with categoryid of 1"] = () =>
            {
                IEnumerable<Product> result_products = productList.GetProductsByCategoryId(1);
                result_products.Should().Contain(products_cat_one);
                result_products.Count().should_be(products_cat_one.Count());
            };


        }
    }
}
