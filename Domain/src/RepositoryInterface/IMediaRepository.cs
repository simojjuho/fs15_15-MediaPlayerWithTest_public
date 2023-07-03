using Domain.Core;

namespace Domain.RepositoryInterface;

public interface IMediaRepository
{
    void Play(int fileId);
    void Pause(int fileId);
    void Stop(int fileId);
    bool CreateNewFile(string fileName, string filePath, TimeSpan duration, TextWriter logger, MediaType type);
    bool DeleteFileById(int fileId);
    List<MediaFile> GetAllFiles();
    MediaFile GetFileById(int fileId);
}