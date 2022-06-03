using Core.Models;

namespace Core.Interfaces {
    public interface IPlaceRepository {

        Task<Place> getById(int id);
        
        Task<IReadOnlyList<Place>> getAll();
    }
}