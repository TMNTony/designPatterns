namespace DesignPatterns.singleton;

public class Singleton
{
    private Singleton(){}

    private static Singleton _instance;
    private static readonly object _lock = new object();

    public static Singleton Instance()
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
            }
        }
        return _instance;
    }
}