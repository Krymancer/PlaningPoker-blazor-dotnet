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

        public async Task InsertAsync(Room room)
        {
            await _context.Rooms.AddAsync(room);
            await _context.SaveChangesAsync();
        }

        public async Task Insert(Room room)
        {
            _context.Add(room);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(Room room)
        {
            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Room room)
        {
            _context.Rooms.Update(room);
            await _context.SaveChangesAsync();
        }
    }
}
