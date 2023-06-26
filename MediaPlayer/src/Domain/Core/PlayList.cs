namespace MediaPlayer.src.Domain.Core
{
    public class PlayList
    {
        private readonly List<MediaFile> _files = new();
        private readonly int _userId;

        public string ListName { get; set; }

        public PlayList(string name, int userId)
        {
            ListName = name;
            _userId = userId;
        }

        public void AddNewFile(MediaFile file, int userId)
        {
            if (CheckUserId(userId))
                _files.Add(file);
        }

        public void RemoveFile(MediaFile file, int userId)
        {
            if (CheckUserId(userId))
                _files.Remove(file);
        }

        public void EmptyList(int userId)
        {
            if (CheckUserId(userId))
                _files.Clear();
        }

        private bool CheckUserId(int userId)
        {
            if (userId == _userId) return true;
            return false;
        }
    }
}