using System.Collections.Generic;

namespace Domain
{
    public class Category : EntityBaseClass
    {
        public string Name { get; set; }

        // navigation
        public virtual IList<Product> Products { get; set; }
        protected internal Category()
        {
            
        }
    
    }

    
}
