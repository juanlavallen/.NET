using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Context {
    public class Context : DbContext {
        public Context(DbContextOptions options) : base(options) {}

        public DbSet<Place> Places { get; set; }
    }
}