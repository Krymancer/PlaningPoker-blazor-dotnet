using PlanningPoker.Models;

namespace PlanningPoker.Data.Repositories.Abstractions
{
    public interface IRoomRepository
    {
        IQueryable<Room> GetAll();        

        IQueryable<Room> GetById(Guid id);        

        Task InsertAsync(Room room);

        Task Insert(Room room);

        Task Remove(Room room);

        Task Update(Room room);        
    }
}
