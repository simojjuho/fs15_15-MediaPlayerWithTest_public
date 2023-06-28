using MediaPlayer.src.Domain.Core;

namespace MediaPlayerTest.Core.Tests;

public class AudioTests
{
    private Audio _audio { get; set; }
    
    public AudioTests()
    {
        _audio = new Audio("audio1", "./audio1", new TimeSpan(0, 0, 3, 30), 1.0);
    }
    
    [Fact]
    public void CreateNewAudio_ValidValues_InstanceCreated()
    {
        Assert.Equal("./audio1", _audio.FilePath);
    }
    
    [Theory]
    [InlineData(0.25)]
    [InlineData(0.5)]
    [InlineData(1.75)]
    [InlineData(2.0)]
    public void SetPlaybackSpeed_ValidValue_IsSet(double speed)
    {
        _audio.Speed = speed;
        
        Assert.Equal(speed, _audio.Speed);
    }
    
    [Theory]
    [InlineData(2.25)]
    [InlineData(0.0)]
    public void SetPlaybackSpeed_InvalidValue_TrowsException(double speed)
    {
        Assert.Throws<ArgumentException>(() => _audio.Speed = speed);
    }
}