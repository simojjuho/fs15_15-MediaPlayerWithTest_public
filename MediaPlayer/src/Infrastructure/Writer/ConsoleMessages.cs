using System.Text;

namespace MediaPlayer.Infrastructure.Writer;

public class ConsoleMessages : TextWriter
{
    public override Encoding Encoding { get; }
    
    public ConsoleMessages()
    {
        Encoding = Encoding.Unicode;
    }
    
    public override void WriteLine(string? message)
    {
        if (message is not null)
        {
            Console.WriteLine($"New message: {message}");
        }    }
}