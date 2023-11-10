﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace assignment2.Models
{
    public class Furniture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; } 
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}