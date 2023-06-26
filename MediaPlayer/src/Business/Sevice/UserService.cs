using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaPlayer.src.Business.ServiceInterface;
using MediaPlayer.src.Domain.RepositoryInterface;

namespace MediaPlayer.src.Business.Sevice
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void AddNewList(string name, int userId)
        {
            _userRepository.AddNewList(name, userId);
        }

        public void EmptyOneList(int listId, int userId)
        {
            _userRepository.EmptyOneList(listId, userId);
        }

        public void GetAllList(int userId)
        {
            _userRepository.GetAllList(userId);
        }

        public void GetListById(int listId)
        {
            _userRepository.GetListById(listId);
        }

        public void RemoveAllLists(int userId)
        {
            _userRepository.RemoveAllLists(userId);
        }

        public void RemoveOneList(int listId, int userId)
        {
            _userRepository.RemoveOneList(listId, userId);
        }
    }
}