namespace PlanningPoker.Server.Models
{
    public class User
    {
        public Guid Id { get; set; }

        public User(Guid id)
        {
            Id = id;
        }
    }
}
