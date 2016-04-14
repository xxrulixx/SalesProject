using System;

namespace Domain
{
    public class EntityClass
    {
        public int Id { get; private set; }

        public DateTime CreatedAt { get; private set; }
        public DateTime ModifiedAt { get; private set; }

    }
}
