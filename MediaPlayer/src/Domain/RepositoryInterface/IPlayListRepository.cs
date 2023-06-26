using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaPlayer.src.Domain.Core;

namespace MediaPlayer.src.Domain.RepositoryInterface
{
    public interface IPlayListRepository
    {
        void AddNewFile(int playListId, int fileId, int userId);
        void RemoveFile(int playListId, int fileId, int userId);
        void EmptyList(int playListId, int userId);
    }
}