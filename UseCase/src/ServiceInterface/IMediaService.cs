using Domain.Core;

namespace UseCase.ServiceInterface;

public interface IMediaService
{
    bool CreateNewFile(string fileName, string filePath, TimeSpan duration, TextWriter logger, MediaType type);
    bool DeleteFileById(int id);
    List<MediaFile> GetAllFiles();
    MediaFile GetFileById(int id);
}