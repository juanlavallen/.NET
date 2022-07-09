using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options) { }

        // TODO: Add DbSets (Tables of our database)
    }
}