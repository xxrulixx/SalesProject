﻿namespace SalesProject.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public float Price { get; set; }
        public int Qty { get; set; }
  
        public Product()
        {
         
            
        }
    }

   
}
