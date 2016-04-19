using Infrastructure.Repositories;
using SalesProject.Models;
using SimpleInjector;

namespace SalesProject
{
    public class DependencyInjection
    {
        public static Container Container { get; set; }

        public static void Initialize()
        {
            Container = new Container();

            Container.Register<ICategoryRepository, CategoryRepository>();
            Container.Register<IProductRepository, ProductRepository>();
            Container.Register<ICategoryList, CategoryList>();
            Container.Register<IProductList, ProductList>();
            Container.Register<ISalesScreen, SalesScreen>();
            

        }
    }
}