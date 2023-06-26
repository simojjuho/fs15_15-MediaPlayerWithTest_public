using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaPlayer.src.Domain.RepositoryInterface;

namespace MediaPlayer.src.Infrastructure.Repository
{
    public class MediaRepository : IMediaRepository
    {
        public void CreateNewFile(string fileName, string filePath, TimeSpan duration)
        {
            throw new NotImplementedException();
        }

        public void DeleteFileById(int fileId)
        {
            throw new NotImplementedException();
        }

        public void GetAllFiles()
        {
            throw new NotImplementedException();
        }

        public void GetFileById(int fileId)
        {
            throw new NotImplementedException();
        }

        public void Pause(int fileId)
        {
            throw new NotImplementedException();
        }

        public void Play(int fileId)
        {
            throw new NotImplementedException();
        }

        public void Stop(int fileId)
        {
            throw new NotImplementedException();
        }
    }
}