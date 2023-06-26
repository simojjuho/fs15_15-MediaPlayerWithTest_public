using MediaPlayer.src.Business.ServiceInterface;

namespace MediaPlayer.src.Application
{
    public class PlayListController
    {
        private readonly IPlayListService _playListService;

        public PlayListController(IPlayListService playListService)
        {
            _playListService = playListService;
        }

        public void AddNewFile(int playListId, int fileId, int userId)
        {
            _playListService.AddNewFile(playListId, fileId, userId);
        }

        public void EmptyList(int playListId, int userId)
        {
            _playListService.EmptyList(playListId, userId);
        }

        public void RemoveFile(int playListId, int fileId, int userId)
        {
            _playListService.RemoveFile(playListId, fileId, userId);
        }
    }
}