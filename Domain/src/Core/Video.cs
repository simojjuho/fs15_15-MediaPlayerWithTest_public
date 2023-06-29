namespace Domain.Core;

public class Video : MediaFile
{
    public Video(string fileName, string filePath, TimeSpan duration, double speed, TextWriter logger) : base(fileName, filePath, duration, logger, speed)
    {
    }
}