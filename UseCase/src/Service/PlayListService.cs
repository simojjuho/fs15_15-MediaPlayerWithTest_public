using Domain.RepositoryInterface;
using UseCase.ServiceInterface;

namespace UseCase.Service;

public class PlayListService : IPlayListService
{
    private readonly IPlayListRepository _playList;

    public PlayListService(IPlayListRepository playList)
    {
        _playList = playList;
    }
    public void AddNewFile(int playListId, int fileId, int userId)
    {
        _playList.AddNewFile(playListId, fileId, userId);
    }

    public void EmptyList(int playListId, int userId)
    {
        _playList.EmptyList(playListId, userId);
    }

    public void RemoveFile(int playListId, int fileId, int userId)
    {
        _playList.RemoveFile(playListId, fileId, userId);
    }
}