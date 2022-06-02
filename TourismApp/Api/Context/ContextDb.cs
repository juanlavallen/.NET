using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Context {
    public class ContextDb : DbContext {
        public ContextDb(DbContextOptions options) : base(options) {}

        public DbSet<Place> Places { get; set; }
    }
}