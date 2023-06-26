using MediaPlayer.src.Domain.Core;

namespace MediaPlayer.src.Domain.RepositoryInterface
{
    public interface IUserRepository
    {
        void AddNewList(string name, int userId);
        void RemoveOneList(int listId, int userId);
        void RemoveAllLists(int userId);
        void EmptyOneList(int listId, int userId);
        void GetAllList(int userId);
        void GetListById(int listId);
    }
}