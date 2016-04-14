using System.Collections.Generic;

namespace Domain
{
    public class Category : EntityBaseClass
    {
        public string Name { get; private set; }

        // navigation
        public IList<Product> Products { get; set; }
        protected internal Category()
        {
            
        }
    
    }

    
}
