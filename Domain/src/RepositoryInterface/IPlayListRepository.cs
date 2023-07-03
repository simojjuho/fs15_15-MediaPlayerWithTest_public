namespace Domain.RepositoryInterface;

public interface IPlayListRepository
{
    bool AddNewFile(int playListId, int fileId, int userId);
    bool RemoveFile(int playListId, int fileId, int userId);
    bool EmptyList(int playListId, int userId);
}