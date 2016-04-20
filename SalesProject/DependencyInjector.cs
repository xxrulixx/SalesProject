using System;
using System.Collections.Generic;
using Caliburn.Micro;
using Infrastructure.Repositories;
using SalesProject.Models;
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

            Container.Register<IWindowManager, WindowManager>();
            Container.RegisterSingleton<IEventAggregator, EventAggregator>();



        }
    }
}