using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {

        }
    }
}
