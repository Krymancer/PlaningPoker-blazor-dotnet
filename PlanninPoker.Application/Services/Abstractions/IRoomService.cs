namespace PlanningPoker.Application.Services.Abstractions
{
    public interface IRoomService
    {
        string[] GetAllRoomsNames();
        void CreateRoom(string roomName);
        void RegisterUser(string roomName, Guid userId);
    }
}
