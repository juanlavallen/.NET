namespace Core.Interfaces {
    public interface IRepository<T> where T : class {
        Task<T> getById(int id);
        Task<IReadOnlyList<T>> getAll();
    }
}