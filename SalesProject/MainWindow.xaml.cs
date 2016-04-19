using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Controls.Primitives;
using Domain;
using Infrastructure;
using Infrastructure.Mappings;
using Infrastructure.Repositories;
using SalesProject.Models;



namespace SalesProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        
        public ObservableCollection<Category> CategoriesObservableCollection { get; set; }
        public ObservableCollection<Product> ProductsObservableCollection { get; set; }
        public ISalesScreen MySalesScreen;

        public MainWindow()
        {
            InitializeComponent();

            DependencyInjection.Initialize();

            MySalesScreen = DependencyInjection.Container.GetInstance<ISalesScreen>();


            MySalesScreen.CategoryListLoaded += (sender, list) =>
                CategoriesObservableCollection = new ObservableCollection<Category>(list);
            MySalesScreen.ProductListLoaded += (sender, list) =>
            {
                if (ProductsObservableCollection == null)
                    ProductsObservableCollection = new ObservableCollection<Product>(list);
                else
                {
                    ProductsObservableCollection.Clear();
                    foreach (var product in list)
                        ProductsObservableCollection.Add(product);
                }
            };

            MySalesScreen.InitializeSalesScreen();
           
    
            
            DataContext = this;
        }           

        private void CartCompleteButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void CategoryToggleButton_Click(object sender, RoutedEventArgs e)
        {
            var button = (ToggleButton) sender;
            var category = (Category) button.DataContext;
            MySalesScreen.ToggleCategory(category);
        }

        private void ProductButton_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
