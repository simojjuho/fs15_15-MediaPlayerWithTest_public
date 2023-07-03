using Domain.RepositoryInterface;
using UseCase.ServiceInterface;

namespace UseCase.Service;

public class PlayListService : IPlayListService
{
    private readonly IPlayListRepository _playListRepository;

    public PlayListService(IPlayListRepository playListRepository)
    {
        _playListRepository = playListRepository;
    }
    
    public void AddNewFile(int playListId, int fileId, int userId)
    {
        _playListRepository.AddNewFile(playListId, fileId, userId);
    }

    public void EmptyList(int playListId, int userId)
    {
        _playListRepository.EmptyList(playListId, userId);
    }

    public void RemoveFile(int playListId, int fileId, int userId)
    {
        _playListRepository.RemoveFile(playListId, fileId, userId);
    }
}