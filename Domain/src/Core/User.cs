namespace Domain.Core;

public class User : BaseEntity
{
    private readonly List<PlayList> _lists = new();
    private static readonly Lazy<User> _lazyInstance = new(() => new User());

    public string Name { get; set; } = string.Empty;

    public List<PlayList> Lists => _lists;

    private User(){}

    public static User Instance => _lazyInstance.Value;

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
}