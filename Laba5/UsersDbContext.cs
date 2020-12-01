using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Laba5
{
    public partial class UsersDbContext: DbContext
    {
        public UsersDbContext()
            : base("name=Labafive")
        {

        }
        public DbSet<Users> Users { get; set; }

    }
}