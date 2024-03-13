namespace DesignPatterns.abstractFactory;

public class Madrid : ICapital
{
    public int getPopulation()
    {
        return 3200000;
    }

    public List<string> listAttractions()
    {
        return new List<string> { "Royal Palace", "Prado Museum" };
    }
}