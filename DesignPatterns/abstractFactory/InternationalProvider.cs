namespace DesignPatterns.abstractFactory;

public class InternationalProvider
{
    public static IInternationalFactory getFactory(Country country)
    {
        switch (country)
        {
            case Country.England:
                return new EnglandFactory();
            case Country.Spain:
                return new SpainFactory();
            default:
                throw new InvalidOperationException(
                    $"{country} is not a valid country");
        }
    }
}