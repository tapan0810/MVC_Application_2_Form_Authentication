using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVC_Application_2_.Models;


namespace MVC_Application_2_.Data
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext():base("DefaultConnection")
        {
        }

        public DbSet<User> Users { get; set; }
    }
}