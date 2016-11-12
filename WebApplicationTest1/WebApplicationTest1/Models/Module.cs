using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplicationTest1.Models
{
    public class Module
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class SolutionsDBContext : DbContext
    {
        public DbSet<Module> Modules { get; set; }
    }
}