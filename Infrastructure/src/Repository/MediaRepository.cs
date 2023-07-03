using Domain.Core;
using Domain.Factory;
using Domain.RepositoryInterface;

namespace Infrastructure.Repository;

public class MediaRepository : IMediaRepository
{
    private List<MediaFile> _repository { get; }

    private static IMediaRepository? _instance { get; set; }
    public static IMediaRepository Instance => _instance ??= new MediaRepository();

    private MediaRepository()
    {
        _repository = new();
    }
    
    public bool CreateNewFile(string fileName, string filePath, TimeSpan duration, TextWriter logger, MediaType type)
    {
        MediaFile file = type switch
        {
            MediaType.Audio => EntityFactory.CreateAudio(fileName, filePath, duration, logger),
            MediaType.Video => EntityFactory.CreateVideo(fileName, filePath, duration, logger),
            _ => throw new ArgumentException("Wrong type of media file given")
        };
        _repository.Add(file);
        return _repository.Contains(file);
    }

    public bool DeleteFileById(int fileId)
    {
        var file = _repository.Find(_ => _.GetId == fileId);
        return _repository.Remove(file);
    }

    public List<MediaFile> GetAllFiles()
    {
        return _repository;
    }

    public MediaFile GetFileById(int fileId)
    {
        var file = _repository.Find(_ => _.GetId == fileId);
        if (file is not null)
        {
            return file;
        }
        else
        {
            throw new ArgumentException("Given id is wrong.");
        }
    }

    public void Pause(int fileId)
    {
        var file = _repository.Find(_ => _.GetId == fileId);
        if (file is not null)
        {
            file.Pause();
        }
        else
        {
            throw new ArgumentException("Given id is wrong.");
        }
    }

    public void Play(int fileId)
    {
        var file = _repository.Find(_ => _.GetId == fileId);
        if (file is not null)
        {
            file.Play();
        }
        else
        {
            throw new ArgumentException("Given id is wrong.");
        }
    }

    public void Stop(int fileId)
    {
        var file = _repository.Find(_ => _.GetId == fileId);
        if (file is not null)
        {
            file.Stop();
        }
        else
        {
            throw new ArgumentException("Given id is wrong.");
        }
    }
}