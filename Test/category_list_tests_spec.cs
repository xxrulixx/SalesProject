using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using Infrastructure.Repositories;
using Moq;
using NSpec;
using SalesProject.Models;
using Domain;
using FluentAssertions;
using Newtonsoft.Json;

namespace Test.Nspec.Debugging
{
    class category_list_tests_spec : nspec
    {
        public Mock<ICategoryRepository> _categoryRepositoryMock;
        public CategoryList categoryList;
        public List<Category> categories;

        private List<Category> _jsonCategories;

        public category_list_tests_spec()
        {
            var jsonString = System.IO.File.ReadAllText(@"./Resources/categories.json");
            _jsonCategories = JsonConvert.DeserializeObject<List<Category>>(jsonString);
            _categoryRepositoryMock = new Mock<ICategoryRepository>();

            _categoryRepositoryMock.Setup(a => a.GetAll()).Returns(_jsonCategories);
            
        }


        void when_creating_it()
        {
            context["with invalid parameters"] = () =>
            {
                it["should not allow a null category list repository"] = () =>
                {
                    Action action = () => new CategoryList(null);
                    action.ShouldThrow<ArgumentNullException>();
                };
            };

            context["with valid parameters"] = () =>
            {
                it["should initialize the category list"] = () =>
                {
                    categoryList = new CategoryList(_categoryRepositoryMock.Object);
                    categoryList.Categories.should_not_be(null);
                };
            };
        }

        
        void when_loading_categories()
        {

            before = () =>
            {
                categoryList = new CategoryList(_categoryRepositoryMock.Object);
                categoryList.LoadCategories();
            };

            it["should call GetAll method from the category list repo"] = () =>
            {
                _categoryRepositoryMock.Verify(a => a.GetAll(), Times.Once);
            };

            it["should set the categories property with the result from the repository"] = () =>
            {
                categoryList.Categories.should_be(_jsonCategories);
            };
        }

        void when_toggling_a_category()
        {
            before = () =>
            {
                categoryList = new CategoryList(_categoryRepositoryMock.Object);
                categoryList.LoadCategories();
            };

            it["category should no be null"] = () =>
            {
                Action action = () => categoryList.ToggleSelected(null);
                action.ShouldThrow<ArgumentNullException>();
            };

            it["should through an exception if category does not exist in my list"] = () =>
            {
                Action action = () => categoryList.ToggleSelected(new Category(1203,"Other category"));
                action.ShouldThrow<ObjectNotFoundException>();
            };

            it["selected property sould be the opposite than before calling the method"] = () =>
            {
                categoryList.Categories.First().Selected = true;
                categoryList.ToggleSelected(categoryList.Categories.First());
                categoryList.Categories.First().Selected.should_be(false);

            };

        }

    }
}
