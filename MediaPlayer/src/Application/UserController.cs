using MediaPlayer.src.Business.ServiceInterface;

namespace MediaPlayer.src.Application
{
    public class UserController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public void AddNewList(string name, int userId)
        {
            _userService.AddNewList(name, userId);
        }

        public void EmptyOneList(int listId, int userId)
        {
            _userService.EmptyOneList(listId, userId);
        }

        public void GetAllList(int userId)
        {
            _userService.GetAllList(userId);
        }

        public void GetListById(int listId)
        {
            _userService.GetListById(listId);
        }

        public void RemoveAllLists(int userId)
        {
            _userService.RemoveAllLists(userId);
        }

        public void RemoveOneList(int listId, int userId)
        {
           _userService.RemoveOneList(listId, userId);
        }
    }
}