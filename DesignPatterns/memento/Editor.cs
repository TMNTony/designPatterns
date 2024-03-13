namespace DesignPatterns.memento;

// Originator
public class Editor
{
    private string _content;

    public string Content
    {
        get { return _content;}
        set { _content = value; }
    }

    public EditorState createState()
    {
        return new EditorState(_content);
    }

    public void restore(EditorState state)
    {
        _content = state.Content;
    }
}