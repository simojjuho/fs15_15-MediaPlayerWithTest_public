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

    public void CreateNewFile(string fileName, string filePath, TimeSpan duration, TextWriter logger)
    {
        _mediaRepository.CreateNewFile(fileName, filePath, duration, logger);
    }

    public void DeleteFileById(int id)
    {
        _mediaRepository.DeleteFileById(id);
    }

    public void GetAllFiles()
    {
        _mediaRepository.GetAllFiles();
    }

    public void GetFileById(int id)
    {
        _mediaRepository.GetFileById(id);
    }
}