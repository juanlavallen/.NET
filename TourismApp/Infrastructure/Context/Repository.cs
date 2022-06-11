using Core.Interfaces;

namespace Infrastructure.Context {
    public class Repository<T> : IRepository<T> where T : class {
        
        public Task<IReadOnlyList<T>> getAll() {
            throw new NotImplementedException();
        }

        public Task<T> getById(int id) {
            throw new NotImplementedException();
        }
    }
}