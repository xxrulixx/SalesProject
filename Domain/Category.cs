using System.Collections.Generic;

namespace Domain
{
    public class Category : EntityBaseClass
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool Selected { get; set; }
        // navigation
        public virtual IList<Product> Products { get; set; }

        public Category()
        {
            
        }
        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    
}
