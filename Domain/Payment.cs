namespace Domain
{
    public class Payment : EntityBaseClass
    {
        public int TypeId { get; private set; }
        public int InvoiceId { get; private set; }
        public float Amount { get; private set; }

        protected internal Payment()
        {
            
        }
    }
}
