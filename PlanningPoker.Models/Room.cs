namespace PlanningPoker.Models
{
    public class Room
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public virtual List<User> Participants { get; set; } = new List<User>();
    }
}
