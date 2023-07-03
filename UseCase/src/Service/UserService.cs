using Domain.Core;
using Domain.RepositoryInterface;
using UseCase.ServiceInterface;

namespace UseCase.Service;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public bool AddNewList(string name, int userId)
    {
        return _userRepository.AddNewList(name, userId);
    }

    public bool EmptyOneList(int listId, int userId)
    {
        return _userRepository.EmptyOneList(listId, userId);
    }

    public List<PlayList> GetAllList(int userId)
    {
        return _userRepository.GetAllList(userId);
    }

    public PlayList GetListById(int listId)
    {
        return _userRepository.GetListById(listId);
    }

    public bool RemoveAllLists(int userId)
    {
        return _userRepository.RemoveAllLists(userId);
    }

    public bool RemoveOneList(int listId, int userId)
    {
        return _userRepository.RemoveOneList(listId, userId);
    }
}