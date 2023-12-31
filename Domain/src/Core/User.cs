using Domain.Core.CoreInterfaces;

namespace Domain.Core;

public class User : BaseEntity, IUser
{
    private readonly List<PlayList> _lists = new();
    private int _id;
    
    private static readonly Lazy<User> _lazyInstance = new(() => new User());

    public List<PlayList> Lists => _lists;
    public string Name { get; set; } = "John / Jane Doe";
    public int GetId => _id;

    public static User Instance => _lazyInstance.Value;

    private User()
    {
        var random = new Random();
        _id = random.Next(4000000);
    }

    public PlayList GetPlaylistById(int playlistId)
    {
        var playlist = _lists.Find(_ => _.GetId == playlistId);
        if (playlist is not null)
        {
            return playlist;
        }

        throw new ArgumentException("Playlist not found");
    }
    
    public bool AddNewList(PlayList list)
    {
        _lists.Add(list);
        return _lists.Contains(list);
    }

    public bool RemoveOneList(PlayList list)
    {
        return _lists.Remove(list);
    }

    public bool EmptyOneList(int listId)
    {
        var list = Lists.Find(_ => _.EmptyList(GetId));
        return list is not null && list.EmptyList(GetId);
    }

    public override string ToString()
    {
        return $"User: {GetId}, {Name}";
    }
}