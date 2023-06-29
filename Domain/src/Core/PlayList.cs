using System.Security.Authentication;

namespace Domain.Core;

public class PlayList
{
    private readonly List<MediaFile> _files = new();
    private readonly int _userId;

    public string ListName { get; set; }

    public PlayList(string name, int userId)
    {
        ListName = name;
        _userId = userId;
    }

    public List<MediaFile> GetAllFiles(int userId)
    {
        if (CheckUserId(userId))
        {
            return _files;
        }
        else
        {
            throw new InvalidCredentialException("Wrong user id");
        }
    }

    public bool AddNewFile(MediaFile file, int userId)
    {
        if (CheckUserId(userId))
        {
            _files.Add(file);
        }

        return _files.Contains(file);
    }

    public bool RemoveFile(MediaFile file, int userId)
    {
        if (CheckUserId(userId))
            return _files.Remove(file);
        return false;
    }

    public bool EmptyList(int userId)
    {
        if (CheckUserId(userId))
            _files.Clear();
        return _files.Count == 0;
    }

    private bool CheckUserId(int userId)
    {
        if (userId == _userId) return true;
        return false;
    }
}