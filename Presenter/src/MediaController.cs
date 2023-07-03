using Domain.Core;
using UseCase.ServiceInterface;

namespace Presenter;

public class MediaController
{
    private readonly IMediaService _mediaService;
    private TextWriter _logger;

    public MediaController(IMediaService mediaService, TextWriter logger)
    {
        _mediaService = mediaService;
        _logger = logger;
    }

    public bool CreateNewFile(string fileName, string filePath, TimeSpan duration, MediaType type)
    {
        return _mediaService.CreateNewFile(fileName, filePath, duration, _logger, type);
    }

    public bool DeleteFileById(int id)
    {
        return _mediaService.DeleteFileById(id);
    }

    public List<MediaFile> GetAllFiles()
    {
        return _mediaService.GetAllFiles();
    }

    public MediaFile GetFileById(int id)
    {
        return _mediaService.GetFileById(id);
    }
}