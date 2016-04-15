using System.Collections.Generic;
using System.Data.Entity;
using Domain;
using Newtonsoft.Json;

namespace Infrastructure
{
    public class SalesDbInitializer : DropCreateDatabaseAlways<SalesContext>
    {
        protected override void Seed(SalesContext context)
        {
            var jsonString = System.IO.File.ReadAllText(@"./Resources/categories.json");
            
            List<Category> categoriesList = JsonConvert.DeserializeObject<List<Category>>(jsonString);

            jsonString = System.IO.File.ReadAllText(@"./Resources/products.json");
            List<Product> productList = JsonConvert.DeserializeObject<List<Product>>(jsonString);


            foreach (var cat in categoriesList)
            {
                context.Categories.Add(cat);
            }

            foreach (var prod in productList)
            {
                context.Products.Add(prod);
            }

            base.Seed(context);
        }

    }

}