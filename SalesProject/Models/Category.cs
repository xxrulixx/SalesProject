using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesProject.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Selected { get; set; }
        public Category()
        {
            Selected = false;
        }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
            Selected = false;
        }
    }

}
