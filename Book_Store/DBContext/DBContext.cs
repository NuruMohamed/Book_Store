using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Book_Store.Models;

namespace Book_Store.DBContext
{
    public class DBContextClass: DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Books> Books { get; set; }
    }
}