using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class Repository<T> : IRepository<T> where T : class
    {

        private readonly ContextDb _db;

        public Repository(ContextDb db) => this._db = db;

        public async Task<IReadOnlyList<T>> getAll()
        {
            return await _db.Set<T>().ToListAsync();
        }

        public async Task<T> getById(int id)
        {
            return await _db.Set<T>().FindAsync(id);
        }
    }
}