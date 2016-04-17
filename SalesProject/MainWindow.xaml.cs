using System.Linq;
using System.Windows;
using Infrastructure;
using Infrastructure.Mappings;
using SalesProject.Models;



namespace SalesProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            SalesScreen sales = new SalesScreen();
            sales.InitializeSalesScreen();

            var tmpCategory = sales.CategoryList.Categories.First();
            sales.ToggleCategory(tmpCategory);

            tmpCategory = sales.CategoryList.Categories.Find(c => c.Id == 2);
            sales.ToggleCategory(tmpCategory);

            sales.Cart.AddProduct(sales.VisibleProducts.First());
            sales.Cart.AddProduct(sales.VisibleProducts.Last());
            float subtotal = sales.Cart.Subtotal();
            sales.Cart.RemoveProduct(sales.Cart.CartProducts.Last());
            subtotal = sales.Cart.Subtotal();

            SalesContext salesData = new SalesContext();
            var lastCategory = salesData.Categories.Find(1).Name.ToString();
            var lastProduct  = salesData.Products.Find(2).Name.ToString();

            var unitOfWork = new UnitOfWork(new SalesContext());
            var uofproducts = unitOfWork.Products.GetTopSellingProducts(2);
            var uofcategories = unitOfWork.Categories.GetAll();
            unitOfWork.Products.RemoveRange(unitOfWork.Products.GetTopSellingProducts(1));
            unitOfWork.Complete();

            lastProduct = uofproducts.Last().ToString();

        }           

       

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
