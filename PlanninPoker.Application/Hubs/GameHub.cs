using Microsoft.AspNetCore.SignalR;
using PlanningPoker.Application.Services.Abstractions;

namespace PlanningPoker.Server.Hubs
{
    public class GameHub : Hub
    {
        private readonly IRoomService roomService;

        public GameHub(IRoomService roomService)
        {
            this.roomService = roomService;
        }

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("Recieve Message", user, message);
        }

        public void CreateRoom(string roomName) => roomService.CreateRoom(roomName);

        public async Task AllRooms() => await Clients.All.SendAsync("AllRooms", roomService.GetAllRoomsNames());

        public void RegisterUser(string roomName, Guid userId) => roomService.RegisterUser(roomName, userId);
        
        public async void RegisterVote(string roomName, Guid userId, string vote) => await Clients.All.SendAsync($"{roomName}-RecieveVote", userId, vote);
    }
}
