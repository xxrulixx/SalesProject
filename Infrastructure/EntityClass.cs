using System;

namespace Infrastructure
{
    public class EntityClass
    {
        public int Id { get; private set; }

        public DateTime CreatedAt { get; private set; }
        public DateTime ModifiedAt { get; private set; }

    }
}
