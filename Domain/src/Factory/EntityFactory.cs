using Domain.Core;

namespace Domain.Factory;

public static class EntityFactory
{
    public static MediaFile CreateAudio(string fileName, string filePath, TimeSpan duration, TextWriter logger)
    {
        return new Audio(fileName, filePath, duration, 1.0, logger);
    }
}