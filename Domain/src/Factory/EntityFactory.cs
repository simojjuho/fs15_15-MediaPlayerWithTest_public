using Domain.Core;

namespace Domain.Factory;

public static class EntityFactory
{
    public static Audio CreateAudio(string fileName, string filePath, TimeSpan duration, TextWriter logger)
    {
        return new Audio(fileName, filePath, duration, 1.0, logger);
    }

    public static Video CreateVideo(string fileName, string filePath, TimeSpan duration, TextWriter logger)
    {
        return new Video(fileName, filePath, duration, 1.0, logger);
    }

    public static PlayList CreatePlaylist(int userId, string name)
    {
        return new PlayList(name, userId);
    }
}