namespace DesignPatterns.strategy;

public abstract class Bird
{
    private FlyBehavior fb;

    public Bird(FlyBehavior flyBehavior)
    {
        fb = flyBehavior;
    }

    public void fly()
    {
        fb.fly();
    }

    public void Swim()
    {
    }

    public void display()
    {
    }
}