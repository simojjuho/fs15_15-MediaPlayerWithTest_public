namespace Domain.Core;

public class Video : MediaFile
{
    public Video(string fileName, string filePath, TimeSpan duration, double speed, TextWriter logger) : base(fileName, filePath, duration, logger, speed)
    {
    }

    public override string ToString()
    {
        return$"Video file: {FileName}, {FilePath}, {Duration}";
    }
}