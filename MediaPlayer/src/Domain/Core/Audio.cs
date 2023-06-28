namespace MediaPlayer.Domain.Core;

public class Audio : MediaFile
{
    public Audio(string fileName, string filePath, TimeSpan duration, double speed, TextWriter logger) : base(fileName, filePath, duration, logger, speed)
    {
    }
}