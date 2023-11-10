using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace assignment2.Models
{
    public class FurnitureContext : DbContext
    {
        public DbSet<Furniture> Furnitures { get; set; }

        public FurnitureContext() : base()
        {
        }
    }
}