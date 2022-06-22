using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class ContextDb : DbContext
    {
        public ContextDb(DbContextOptions options) : base(options) { }
    }
}