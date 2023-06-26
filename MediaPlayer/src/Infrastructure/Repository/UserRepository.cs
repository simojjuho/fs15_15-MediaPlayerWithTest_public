using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaPlayer.src.Domain.Core;
using MediaPlayer.src.Domain.RepositoryInterface;

namespace MediaPlayer.src.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        public UserRepository(){}

        public void AddNewList(string name, int userId)
        {
            throw new NotImplementedException();
        }

        public void EmptyOneList(int listId, int userId)
        {
            throw new NotImplementedException();
        }

        public void GetAllList(int userId)
        {
            throw new NotImplementedException();
        }

        public void GetListById(int listId)
        {
            throw new NotImplementedException();
        }

        public void RemoveAllLists(int userId)
        {
            throw new NotImplementedException();
        }

        public void RemoveOneList(int listId, int userId)
        {
            throw new NotImplementedException();
        }

    }
}