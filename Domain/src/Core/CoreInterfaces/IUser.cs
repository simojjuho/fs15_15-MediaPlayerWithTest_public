using Domain.Core;
using Domain.RepositoryInterface;

namespace Domain.Core.CoreInterfaces;

public interface IUser
{
    List<PlayList> Lists { get; }
    int GetId { get; }
    PlayList GetPlaylistById(int playlistId);
    bool AddNewList(PlayList list);
    bool RemoveOneList(PlayList list);
    bool EmptyOneList(int listId);
}