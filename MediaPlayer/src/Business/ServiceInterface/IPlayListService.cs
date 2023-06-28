namespace MediaPlayer.Business.ServiceInterface
{
    public interface IPlayListService
    {
        void AddNewFile(int playListId, int fileId, int userId);
        void RemoveFile(int playListId, int fileId, int userId);
        void EmptyList(int playListId, int userId);
    }
}