using PracticeCexV2.Web.DomainModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PracticeCexV2.Web.DbContexts
{
    public class PracticeCexV2DbContext : DbContext
    {
        public PracticeCexV2DbContext() : base("PracticeCexV2Connection")
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}