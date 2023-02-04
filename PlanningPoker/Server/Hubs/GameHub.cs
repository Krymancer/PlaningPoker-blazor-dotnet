using Microsoft.AspNetCore.SignalR;
using PlanningPoker.Server.Models;

namespace PlanningPoker.Server.Hubs
{
    public class GameHub : Hub
    {
        private readonly List<Room> _rooms = new List<Room>() { new Room("Default")};

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("Recieve Message", user, message);
        }

        public void CreateRoom(string roomName)
        {
            if(roomName == null && _rooms.Any(x => x.Name == roomName)) {
                return;
            }

            var room = new Room(roomName!);

            _rooms.Add(room);
        }

        public async Task AllRooms()
        {
            await Clients.All.SendAsync("AllRooms", _rooms.Select(x => x.Name).ToArray());
        }
    }
}
