namespace PlanningPoker.Server.Models
{
    public class Room
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public IEnumerable<User> Participants { get; set; } = Enumerable.Empty<User>();


        public Room(string roomName)
        {
            Name = roomName;
            Id = Guid.NewGuid();
        }
    }
}
