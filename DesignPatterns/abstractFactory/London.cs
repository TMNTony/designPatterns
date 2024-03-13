namespace DesignPatterns.abstractFactory;

public class London : ICapital
{
    public int getPopulation()
    {
        return 8900000;
    }

    public List<string> listAttractions()
    {
        return new List<string> { "Tower Bridge", "Buckingham Palace" };
    }
}