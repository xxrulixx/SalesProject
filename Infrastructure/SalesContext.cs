using System.Data.Entity;
using Domain;

namespace Infrastructure
{
    public class SalesContext : DbContext
    {
        public SalesContext() : base()
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<InvoiceProduct> InvoiceProducts { get; set; }
    }
}
