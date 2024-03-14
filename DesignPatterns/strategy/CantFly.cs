namespace DesignPatterns.strategy;

public class CantFly : FlyBehavior
{
    public void fly()
    {
        Console.WriteLine("I don't fly");
    }
}