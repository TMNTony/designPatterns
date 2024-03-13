namespace DesignPatterns.state;

public class SelectionTool : Tool
{
    public void mouseDown()
    {
        Console.WriteLine("Selection icon");
    }

    public void mouseUp()
    {
        Console.WriteLine("Draw dashed rectangle");
    }
}