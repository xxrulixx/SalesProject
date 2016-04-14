using System.Linq;
using System.Windows;
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

        }           

       

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
