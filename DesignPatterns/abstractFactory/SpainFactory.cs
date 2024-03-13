namespace DesignPatterns.abstractFactory;

public class SpainFactory : IInternationalFactory
{
    public SpainFactory()
    {
            
    }
    public ILanguage createLanguage()
    {
        return new Spanish();
    }

    public ICapital createCapital()
    {
        return new Madrid();
    }
}