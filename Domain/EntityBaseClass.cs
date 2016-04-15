using System;
using static System.DateTime;

namespace Domain
{
    public class EntityBaseClass
    {
        public int Id { get;  set; }

        public DateTime CreatedAt { get;   set; }
        public DateTime ModifiedAt { get;   set; }

        public EntityBaseClass()
        {
            CreatedAt = new DateTime();
            CreatedAt = DateTime.Now;
            ModifiedAt = new DateTime();
            ModifiedAt = DateTime.Now;
        }
    }

    

}
