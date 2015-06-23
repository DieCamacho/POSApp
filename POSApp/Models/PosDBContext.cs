using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace POSApp.Models
{
    public class PosDBContext : DbContext
    {
        public DbSet<Products> Products { get; set; }
    }
}