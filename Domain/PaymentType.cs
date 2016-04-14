namespace Domain
{
    public class PaymentType : EntityBaseClass
    {
        public string Name { get; private set; }

        //navigation prop
        public Payment Payment { get; set; }

        protected internal PaymentType()
        {
            
        }
    }
}
