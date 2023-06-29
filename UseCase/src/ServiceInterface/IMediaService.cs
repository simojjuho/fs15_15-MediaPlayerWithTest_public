namespace UseCase.ServiceInterface;

public interface IMediaService
{
    void CreateNewFile(string fileName, string filePath, TimeSpan duration);
    void DeleteFileById(int id);
    void GetAllFiles();
    void GetFileById(int id);
}