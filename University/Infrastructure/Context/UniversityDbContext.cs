using Microsoft.EntityFrameworkCore;
using Core.Models;

namespace Infrastructure.Context
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options) { }

        // TODO: Add DbSets (Tables of our database)
        public DbSet<User> Users { get; set; }
    }
}