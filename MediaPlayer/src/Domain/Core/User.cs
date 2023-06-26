namespace MediaPlayer.src.Domain.Core
{
    public class User : BaseEntity
    {
        private readonly List<PlayList> _lists = new();
        private static readonly Lazy<User> lazyInstance = new(() => new User());

        public string Name { get; set; } = string.Empty;

        private User(){}

        public static User Instance => lazyInstance.Value;

        public void AddNewList(PlayList list)
        {
            _lists.Add(list);
        }

        public void RemoveOneList(PlayList list)
        {
            _lists.Remove(list);
        }

        public void EmptyOneList(PlayList list)
        {
            if (_lists.Contains(list))
                list.EmptyList(GetId);
            else
                throw new ArgumentNullException("Playlist is not found");
        }
    }
}