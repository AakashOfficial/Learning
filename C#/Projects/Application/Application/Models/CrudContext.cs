using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Application.Models
{
    public class CrudContext : DbContext
    {
        public DbSet<UserModel> user { get; set; }
    }
}