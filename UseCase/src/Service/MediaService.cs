using Domain.Core;
using Domain.RepositoryInterface;
using UseCase.ServiceInterface;

namespace UseCase.Service;

public class MediaService : IMediaService
{
    private readonly IMediaRepository _mediaRepository;
    private TextWriter _logger;

    public MediaService(IMediaRepository mediaRepository, TextWriter logger)
    {
        _mediaRepository = mediaRepository;
        _logger = logger;
    }

    public bool CreateNewFile(string fileName, string filePath, TimeSpan duration, TextWriter logger, MediaType type)
    {
        return _mediaRepository.CreateNewFile(fileName, filePath, duration, logger, type);
    }

    public bool DeleteFileById(int id)
    {
        return _mediaRepository.DeleteFileById(id);
    }

    public List<MediaFile> GetAllFiles()
    {
        return _mediaRepository.GetAllFiles();
    }

    public MediaFile GetFileById(int id)
    {
        return _mediaRepository.GetFileById(id);
    }
}