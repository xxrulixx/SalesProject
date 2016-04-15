using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Domain;
using Infrastructure.Mappings;
using Newtonsoft.Json;

namespace Infrastructure
{
    public class SalesContext : DbContext
    {
        public SalesContext() : base()
        {
            Database.SetInitializer<SalesContext>(new SalesDbInitializer());// CreateDatabaseIfNotExists<SalesContext>());
            
        }

       

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<InvoiceProduct> InvoiceProducts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new CategoryMapping());
            modelBuilder.Configurations.Add(new ProductMapping());
            modelBuilder.Configurations.Add(new PaymentTypeMapping());
            modelBuilder.Configurations.Add(new PaymentMapping());
            modelBuilder.Configurations.Add(new InvoiceMapping());
            modelBuilder.Configurations.Add(new InvoiceProductMapping());
        }
    }
}
