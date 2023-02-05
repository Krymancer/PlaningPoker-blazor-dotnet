namespace PlanningPoker.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Guid RoomId { get; set; }
        public virtual Room? Room { get; set; }
    }
}
