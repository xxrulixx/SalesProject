﻿using System;
using System.Collections.Generic;
using Caliburn.Micro;
using Infrastructure.Repositories;
using SalesProject.Models;
using SalesProject.ViewModels;
using SimpleInjector;

namespace SalesProject
{
    public class DependencyInjector
    {
        private IEnumerable<Type> _allTypes;

        /// <summary>
        /// The dependency injection container
        /// </summary>
        public Container Container { get; private set; }

        /// <summary>
        /// Initializes the dependency injection modoule
        /// </summary>

        public void Initialize()
        {
            Container = new Container();

            Container.Register<ICategoryRepository, CategoryRepository>();
            Container.Register<IProductRepository, ProductRepository>();
            Container.Register<ICategoryList, CategoryList>();
            Container.Register<IProductList, ProductList>();
            Container.Register<ISalesScreen, SalesScreen>();
            Container.Register<ICart, Cart>();

            Container.RegisterSingleton<IWindowManager, WindowManager>();
            Container.RegisterSingleton<IEventAggregator, EventAggregator>();

            Container.Register<CategoryListViewModel>();
            Container.Register<ProductListViewModel>();
            Container.Register<CartViewModel>();
            Container.Register<CartItemViewModel>();


        }
    }
}