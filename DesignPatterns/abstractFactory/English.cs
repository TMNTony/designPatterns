namespace DesignPatterns.abstractFactory;

public class English : ILanguage
{
    public void Greet()
    {
        Console.WriteLine("Hello!");
    }
}