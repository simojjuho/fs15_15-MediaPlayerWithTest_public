using System.Security.Authentication;
using System.Text;

namespace Domain.Core;

public class PlayList
{
    private readonly List<MediaFile> _files = new();
    private readonly int _id;
    private readonly int _userId;

    public string ListName { get; set; }

    public int GetId => _id;

    public PlayList(string name, int userId)
    {
        var random = new Random();
        ListName = name;
        _userId = userId;
        _id = random.Next(4000000);
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

    public override string ToString()
    {
        var output = new StringBuilder();
        output.Append($"Playlist {ListName}\n");
        foreach (var file in _files)
        {
            output.Append(file + "\n");
        }

        output.Append($"---{_files.Count} files---");
        return output.ToString();
    }

    private bool CheckUserId(int userId)
    {
        if (userId == _userId) return true;
        return false;
    }
}