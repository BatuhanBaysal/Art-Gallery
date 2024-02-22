using System;
using System.Data.Entity;
using System.Linq;

namespace Group_5.Models
{
    public class DbPersonel : DbContext
    {
       
        public DbPersonel()
            : base("name=DbPersonel")
        {
        }
        public System.Data.Entity.DbSet<Group_5.Models.User> Users { get; set; }
    }
}