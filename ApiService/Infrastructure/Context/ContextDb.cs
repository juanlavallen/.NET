using Microsoft.EntityFrameworkCore;
using Core.Entities;

namespace Infrastructure.Context
{
    public class ContextDb : DbContext
    {
        public ContextDb(DbContextOptions options) : base(options) { }

        DbSet<User> Users { get; set; }
    }
}