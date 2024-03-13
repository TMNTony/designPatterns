namespace DesignPatterns.state;

public class Canvas
{
    private Tool currentTool;

    public void mouseDown()
    {
        currentTool.mouseDown();
    }

    public void mouseUp()
    {
        currentTool.mouseUp();
    }

    public Tool CurrentTool
    {
        get => currentTool;
        set => currentTool = value;
    }
    
}