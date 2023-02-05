using PlanningPoker.Application.Services.Abstractions;
using PlanningPoker.Data.Repositories.Abstractions;
using PlanningPoker.Models;
using System.Linq;

namespace PlanningPoker.Application.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IUserRepository _userRepository;

        public RoomService(IRoomRepository roomRepository, IUserRepository userRepository)
        {
            _roomRepository = roomRepository;
            _userRepository = userRepository;
        }

        public string[] GetAllRoomsNames() => _roomRepository.GetAll().Select(r => r.Name).ToArray();

        public async void CreateRoom(string roomName)
        {
            var room = new Room()
            {
                Id = Guid.NewGuid(),
                Name = roomName,
                Participants = new List<User>()
            };

            var roomObject = _roomRepository.GetAll().Where(x => x.Name == roomName).FirstOrDefault();

            if (roomObject is not null) return;

            await _roomRepository.InsertAsync(room);
        }

        public void RegisterUser(string roomName, Guid userId)
        {
            var room = _roomRepository.GetAll().Where(x => x.Name == roomName).FirstOrDefault();

            if (room is null) return;

            var user = new User()
            {
                Id = userId
            };

            room.Participants.Add(user);
        }
    }
}
