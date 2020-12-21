using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TrackMyWork.API.Models.Appcontext
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserRights> Rights { get; set; }
        public DbSet<UserRoles> Roles { get; set; }
    }
}
