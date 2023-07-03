using Domain.Core;
using Domain.RepositoryInterface;

namespace Infrastructure.Repository;

public class PlayListRepository : IPlayListRepository
{
    private List<PlayList> _playlists { get; }
    private IMediaRepository _mediaRepository;

    private static IPlayListRepository? _instance;

    public static IPlayListRepository Instance(IMediaRepository mediaRepo)
    {
        return _instance ??= new PlayListRepository(mediaRepo);
    }

    private PlayListRepository(IMediaRepository mediaRepo)
    {
        _playlists = new();
        _mediaRepository = mediaRepo;
    }
    
    public bool AddNewFile(int playListId, int fileId, int userId)
    {
        var playlist = getPlaylistById(playListId);
        var file = _mediaRepository.GetFileById(fileId);
        return playlist.AddNewFile(file, userId);
    }

    public bool EmptyList(int playListId, int userId)
    {
        var playlist = getPlaylistById(playListId);
        return playlist.EmptyList(userId);
    }

    public bool RemoveFile(int playListId, int fileId, int userId)
    {
        var playlist = getPlaylistById(playListId);
        var file = _mediaRepository.GetFileById(fileId);
        return playlist.RemoveFile(file, userId);
    }

    private PlayList getPlaylistById(int playlistId)
    {
        var playlist = _playlists.Find(_ => _.GetId == playlistId);
        if (playlist is not null)
        {
            return playlist;
        }

        throw new ArgumentException("Wrong playlist id");
    }
}