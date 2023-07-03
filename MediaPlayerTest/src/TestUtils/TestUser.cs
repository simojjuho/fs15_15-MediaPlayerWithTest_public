using Domain.Core;
using Domain.Core.CoreInterfaces;

namespace MediaPlayerTest.TestUtils;

public class TestUser : IUser
{
    public List<PlayList> Lists { get; }
    public int GetId { get; }

    public PlayList GetPlaylistById(int playlistId)
    {
        throw new NotImplementedException();
    }

    public bool AddNewList(PlayList list)
    {
        throw new NotImplementedException();
    }

    public bool RemoveOneList(PlayList list)
    {
        throw new NotImplementedException();
    }

    public bool EmptyOneList(int listId)
    {
        throw new NotImplementedException();
    }
}