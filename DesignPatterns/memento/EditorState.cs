namespace DesignPatterns.memento;
// Memento
public class EditorState
{
    private string _content;

    public string Content
    {
        get => _content;
    }

    public EditorState(string content)
    {
        _content = content;
    }
}