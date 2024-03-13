namespace DesignPatterns.state;

public class BrushTool : Tool
{
    public void mouseDown()
    {
        Console.WriteLine("Brush icon");
    }

    public void mouseUp()
    {
        Console.WriteLine("Draw a line");
    }
}