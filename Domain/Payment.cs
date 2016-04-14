using Domain;

namespace Infrastructure
{
    class Payment : EntityClass
    {
        public int TypeId { get; private set; }
        public int InvoiceId { get; private set; }
        public float Amount { get; private set; }
    }
}
