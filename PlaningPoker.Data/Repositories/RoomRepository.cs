using PlanningPoker.Data.Repositories.Abstractions;
using PlanningPoker.Models;

namespace PlanningPoker.Data.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly AppContext _context;

        public RoomRepository(AppContext context)
        {
            _context = context;
        }

        public IQueryable<Room> GetAll()
        {
            return _context.Rooms;
        }

        public IQueryable<Room> GetById(Guid id)
        {
            return _context.Rooms.Where(x => x.Id == id);
        }

        public async void InsertAsync(Room room)
        {
            await _context.Rooms.AddAsync(room);
        }

        public void Insert(Room room)
        {
            _context.Add(room);
        }

        public void Remove(Room room)
        {
            _context.Rooms.Remove(room);
        }

        public void Update(Room room)
        {
            _context.Rooms.Update(room);
        }
    }
}
