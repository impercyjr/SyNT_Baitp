using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HelloCovi.Models
{
    public class MyDb : DbContext
    {
        public MyDb() : base("MyConnectionString")
        {
        }

        public System.Data.Entity.DbSet<HelloCovi.Models.Student> Students { get; set; }
    }
}