using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LPCMSWeb.Models
{
    public class CmsDbContext:DbContext
    {
        public CmsDbContext():base("name=LPCMSConnection")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Admintrator> Admintrators { get; set; }
    }
}