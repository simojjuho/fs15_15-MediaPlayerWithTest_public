using Domain.Core;
using UseCase.ServiceInterface;

namespace Presenter;

public class UserController
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    public void AddNewList(string name, int userId)
    {
        _userService.AddNewList(name, userId);
    }

    public void EmptyOneList(int listId, int userId)
    {
        _userService.EmptyOneList(listId, userId);
    }

    public List<PlayList> GetAllList(int userId)
    {
        return _userService.GetAllList(userId);
    }

    public PlayList GetListById(int listId)
    {
        return _userService.GetListById(listId);
    }

    public bool RemoveAllLists(int userId)
    {
        return _userService.RemoveAllLists(userId);
    }

    public bool RemoveOneList(int listId, int userId)
    {
        return _userService.RemoveOneList(listId, userId);
    }
}