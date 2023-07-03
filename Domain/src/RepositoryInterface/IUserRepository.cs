using Domain.Core;
using Domain.Core.CoreInterfaces;

namespace Domain.RepositoryInterface;

public interface IUserRepository
{
    bool AddNewUser(IUser user);
    bool AddNewList(string name, int userId);
    bool RemoveOneList(int listId, int userId);
    bool RemoveAllLists(int userId);
    bool EmptyOneList(int listId, int userId);
    List<PlayList> GetAllList(int userId);
    PlayList GetListById(int listId);
}