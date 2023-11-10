using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace assignment2.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } 
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        
    }
}