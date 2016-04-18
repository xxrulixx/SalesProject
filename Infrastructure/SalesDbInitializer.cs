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
            context.Categories.AddRange(JsonConvert.DeserializeObject<List<Category>>(jsonString));

            jsonString = System.IO.File.ReadAllText(@"./Resources/products.json");
            context.Products.AddRange(JsonConvert.DeserializeObject<List<Product>>(jsonString));

            base.Seed(context);
        }

    }

}