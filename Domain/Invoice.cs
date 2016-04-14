using System;

namespace Domain
{
    class Invoice : EntityClass
    {
        public DateTime TimeStamp { get; private set; }
        public float    Subtotal { get; private set; }
        public float Tax { get; private set; }
        public float Total { get; private set; }    

    }
}
