using PlanningPoker.Models;

namespace PlanningPoker.Data.Repositories.Abstractions
{
    public interface IUserRepository
    {
        IQueryable<User> GetAll();

        IQueryable<User> GetById(Guid id);

        void InsertAsync(User user);

        void Insert(User user);

        void Remove(User user);

        void Update(User user);
    }
}
