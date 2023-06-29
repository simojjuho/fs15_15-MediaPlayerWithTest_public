namespace Domain.Core;

public class User : BaseEntity
{
    private readonly List<PlayList> _lists = new();
    private static readonly Lazy<User> lazyInstance = new(() => new User());

    public string Name { get; set; } = string.Empty;

    public List<PlayList> Lists => _lists;

    private User(){}

    public static User Instance => lazyInstance.Value;

    public bool AddNewList(PlayList list)
    {
        _lists.Add(list);
        return _lists.Contains(list);
    }

    public bool RemoveOneList(PlayList list)
    {
        return _lists.Remove(list);
    }

    public bool EmptyOneList(PlayList list)
    {
        if (_lists.Contains(list))
        {
            list.EmptyList(GetId);
            return list.GetAllFiles(GetId).Count == 0;
        }
        else
            throw new ArgumentNullException("Playlist is not found");
    }
}