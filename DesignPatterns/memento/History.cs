namespace DesignPatterns.memento;
// Caretaker
public class History
{
    private List<EditorState> _history = new List<EditorState>();

    public void push(EditorState state)
    {
        _history.Add(state);
    }

    public EditorState pop()
    {
        var lastIndex = _history.Count - 1;
        var lastState = _history[lastIndex];
        _history.RemoveAt(lastIndex);
        
        return lastState;
    }
}