using Domain.Core;
using Domain.Factory;
using Domain.RepositoryInterface;

namespace Infrastructure.Repository;

public class UserRepository : IUserRepository
{
    private List<User> _users;
    
    private static UserRepository? _instance { get; set; }

    public static UserRepository Instance => _instance ??= new UserRepository();
    
    private UserRepository(){}

    public bool AddNewList(string name, int userId)
    {
        var user = getUserById(userId);
        return user.AddNewList(EntityFactory.CreatePlaylist(userId, name));
    }

    public bool EmptyOneList(int listId, int userId)
    {
        var user = getUserById(userId);
        return user.EmptyOneList(listId);
        }

    public List<PlayList> GetAllList(int userId)
    {
        var user = getUserById(userId);
        return user.Lists;
    }

    public PlayList GetListById(int listId)
    {
        foreach (var user in _users)
        {
            var list = user.Lists.Find(_ => _.GetId == listId);
            if (list is not null) return list;
        }

        throw new ArgumentException("Incorrect list id");
    }

    public bool RemoveAllLists(int userId)
    {
        var user = getUserById(userId);
        foreach (var list in user.Lists)
        {
            user.RemoveOneList(list);
        }

        return user.Lists.Count == 0;
    }

    public bool RemoveOneList(int listId, int userId)
    {
        var user = getUserById(userId);
        var list = user.GetPlaylistById(listId);
        return user.RemoveOneList(list);
    }

    private User getUserById(int userId)
    {
        var user = _users.Find(_ => _.GetId == userId);
        if (user is not null)
        {
            return user;
        }
        
        throw new ArgumentException("Incorrect user id"); 
    }

}