using System.Text;

namespace MediaPlayerTest.TestUtils;

public class StringLogger
{
    public StringBuilder Content { get; }
    public StringWriter Logger { get; set; }

    public StringLogger()
    {
        Content = new();
        Logger = new(Content);
    }

    public void EmptyContent()
    {
        Content.Clear();
    }

    public override string ToString()
    {
        return Content.ToString();
    }
}