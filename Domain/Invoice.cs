using System;

namespace Domain
{
    public class Invoice : EntityBaseClass
    {
        public DateTime TimeStamp { get; private set; }
        public float    Subtotal { get; private set; }
        public float Tax { get; private set; }
        public float Total { get; private set; }

        protected internal Invoice()
        {
            
        }
    }
}
