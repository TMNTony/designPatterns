namespace DesignPatterns.abstractFactory;

public class EnglandFactory : IInternationalFactory
{
    public EnglandFactory()
    {
        
    }
    public ILanguage createLanguage()
    {
        return new English();
    }

    public ICapital createCapital()
    {
        return new London();
    }
}