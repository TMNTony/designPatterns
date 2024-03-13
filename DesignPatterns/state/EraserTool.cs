namespace DesignPatterns.state;

public class EraserTool : Tool
{
    public void mouseDown()
    {
        Console.WriteLine("Eraser icon");
    }

    public void mouseUp()
    {
        Console.WriteLine("Erase content");
    }
}