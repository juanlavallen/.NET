using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context {
    public class ContextDb : DbContext {
        public ContextDb(DbContextOptions options) : base(options) {}

        public DbSet<Place> Places { get; set; }
    }
}