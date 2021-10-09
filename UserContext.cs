using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace FunctionApp33
{
    class UserContext: DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
