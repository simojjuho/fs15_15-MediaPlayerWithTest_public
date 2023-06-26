using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaPlayer.src.Business.ServiceInterface
{
    public interface IPlayListService
    {
        void AddNewFile(int playListId, int fileId, int userId);
        void RemoveFile(int playListId, int fileId, int userId);
        void EmptyList(int playListId, int userId);
    }
}