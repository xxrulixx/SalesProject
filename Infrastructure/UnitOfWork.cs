using Infrastructure.Repositories;

namespace Infrastructure
{
   public class UnitOfWork : IUnitOfWork
    {
        private readonly SalesContext _context;
        public void Dispose()
        {
            _context.Dispose();
        }
        
        public ICategoryRepository Categories { get; }
        public IProductRepository Products { get; }
        public IInvoiceRepository Invoices { get; }
        public void Complete()
        {
            _context.SaveChanges();
        }

        public UnitOfWork(SalesContext context)
        {
            _context = context;
            Products = new ProductRepository(_context);
            Categories = new CategoryRepository(_context);
            Invoices = new InvoiceRepository(_context);
        }
    }
}
