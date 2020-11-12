using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Product
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal CategoryId { get; set; }
        public bool isDeleted { get; set; }
        public decimal Price { get; set; }
        public string InnerBarcode { get; set; }
        public virtual Category Category { get; set; }
    }
}
