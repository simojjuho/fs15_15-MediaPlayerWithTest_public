namespace Domain.Core.CoreInterfaces;

public interface IPlayList
{
    List<MediaFile> GetAllFiles(int userId);
    bool AddNewFile(MediaFile file, int userId);
    bool RemoveFile(MediaFile file, int userId);
    bool EmptyList(int userId);
}