namespace DesignPatterns.strategy;

public class Penguin : Bird
{
    public Penguin(FlyBehavior flyBehavior) : base(flyBehavior)
    {
    }
}