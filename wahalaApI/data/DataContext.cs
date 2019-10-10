using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using wahalaApI.Models;

namespace wahalaApI.data
{
    public class DataContext : IdentityDbContext
    {
        public DataContext()
        {
            
        }
        public DbSet<User> Team { get; set; }
        public DbSet<Wahala> Wahala { get; set; }
    }
}