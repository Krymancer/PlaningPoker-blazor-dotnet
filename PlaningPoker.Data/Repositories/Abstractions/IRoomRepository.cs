using PlanningPoker.Models;

namespace PlanningPoker.Data.Repositories.Abstractions
{
    public interface IRoomRepository
    {
        IQueryable<Room> GetAll();        

        IQueryable<Room> GetById(Guid id);        

        void InsertAsync(Room room);        

        void Insert(Room room);        

        void Remove(Room room);        

        void Update(Room room);        
    }
}
