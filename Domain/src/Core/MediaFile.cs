namespace Domain.Core;

public abstract class MediaFile : BaseEntity
{
    private double _playbackSpeed;
    private bool _isPlaying;
    private TimeSpan _currentPosition;
    private Timer? _timer;
    private TextWriter _logger { get; }

    public string FileName { get; set; }
    public string FilePath { get; set; }
    public TimeSpan Duration { get; set; }
    public double Speed
    {
        get => _playbackSpeed;
        set
        {
            if (IsValidPlaybackSpeed(value))
            {
                _playbackSpeed = value;
                //re play to get new speed
                Pause();
                Play();
            }
            else
            {
                throw new ArgumentException("Not a valid speed value");
            }
        }
    }

    protected MediaFile(string fileName, string filePath, TimeSpan duration, TextWriter logger, double speed)
    {
        _isPlaying = false;
        _currentPosition = TimeSpan.Zero;
        _logger = logger;
        FileName = fileName;
        FilePath = filePath;
        Duration = duration;
        Speed = speed;
    }

    public void Play()
    {
        if (!_isPlaying)
        {
            _isPlaying = true;
            _logger.WriteLine("Playing...");

            // Start a timer to increase the current position every second
            _timer = new Timer(UpdatePosition, null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
        }
    }

    public void Pause()
    {
        if (_isPlaying)
        {
            _isPlaying = false;
            Console.WriteLine("Paused.");

            // Stop the timer when pausing the playback
            _timer?.Change(Timeout.Infinite, Timeout.Infinite);
        }
    }

    public void Stop()
    {
        if (_isPlaying)
        {
            _isPlaying = false;
            _logger.WriteLine("Stopped.");

            // Stop the timer and reset the current position
            _timer?.Change(Timeout.Infinite, Timeout.Infinite);
            _currentPosition = TimeSpan.Zero;
        }
    }

    private static bool IsValidPlaybackSpeed(double speed)
    {
        double[] validSpeeds = { 0.25, 0.5, 1, 1.25, 1.5, 1.75, 2 };
        return validSpeeds.Contains(speed);
    }

    private void UpdatePosition(object? state)
    {
        if (_isPlaying)
        {
            _currentPosition += TimeSpan.FromSeconds(Speed);

            if (_currentPosition >= Duration)
            {
                Stop();
            }
        }
    }
}