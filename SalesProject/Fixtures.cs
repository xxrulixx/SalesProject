using Newtonsoft.Json;
using SalesProject.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SalesProject
{
    public class Fixtures
    {
        public static IEnumerable<Category> GetCategories()
        {
            var jsonString = System.IO.File.ReadAllText(@"./Resources/categories.json");
            List<Category> categoriesList = JsonConvert.DeserializeObject<List<Category>>(jsonString);
            return categoriesList;

        }

        public static IEnumerable<Product> GetProducts()
        {
            var jsonString = System.IO.File.ReadAllText(@"./Resources/products.json");
            List<Product> productList = JsonConvert.DeserializeObject<List<Product>>(jsonString);
            return productList;
        } 

    }
}
