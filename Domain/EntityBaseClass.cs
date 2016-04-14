using System;

namespace Domain
{
    public class EntityBaseClass
    {
        public int Id { get; private set; }

        public DateTime CreatedAt { get; private set; }
        public DateTime ModifiedAt { get; private set; }

    }
}
