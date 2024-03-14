namespace DesignPatterns.strategy;

public class FlyWithWings : FlyBehavior
{
    
    public void fly()
    {
        Console.WriteLine("Flying with wings!");
    }
}