using Core.Interfaces;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context {
    public class PlaceRepository : IPlaceRepository {

        private readonly ContextDb _db;

        public PlaceRepository(ContextDb db) {
            this._db = db;
        }

        public async Task<Place> getById(int id) {
            return await _db.Places.FindAsync(id);
        }

        public async Task<IReadOnlyList<Place>> getAll() {
            return await _db.Places.ToListAsync();
        }
    }
}