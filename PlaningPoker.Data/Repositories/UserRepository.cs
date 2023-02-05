using PlanningPoker.Data.Repositories.Abstractions;
using PlanningPoker.Models;

namespace PlanningPoker.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppContext _context;

        public UserRepository(AppContext context)
        {
            _context = context;
        }

        public IQueryable<User> GetAll()
        {
            return _context.Users;
        }

        public IQueryable<User> GetById(Guid id)
        {
            return _context.Users.Where(x => x.Id == id);
        }

        public void Insert(User user)
        {
            _context.Users.Add(user);
        }

        public void InsertAsync(User user)
        {
            _context.Users.AddAsync(user);
        }

        public void Remove(User user)
        {
            _context.Users.Remove(user);
        }

        public void Update(User user)
        {
            _context.Users.Update(user);
        }
    }
}
