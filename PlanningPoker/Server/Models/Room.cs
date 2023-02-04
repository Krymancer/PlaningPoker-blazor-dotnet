namespace PlanningPoker.Server.Models
{
    public class Room
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<User> Participants { get; set; }


        public Room(string roomName)
        {
            Name = roomName;
            Id = Guid.NewGuid();
            Participants = new List<User>();
        }
    }
}
