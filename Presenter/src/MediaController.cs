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

    public void CreateNewFile(string fileName, string filePath, TimeSpan duration)
    {
        _mediaService.CreateNewFile(fileName, filePath, duration, _logger);
    }

    public void DeleteFileById(int id)
    {
        _mediaService.DeleteFileById(id);
    }

    public void GetAllFiles()
    {
        _mediaService.GetAllFiles();
    }

    public void GetFileById(int id)
    {
        _mediaService.GetFileById(id);
    }
}