namespace DesignPatterns.factory;

public class GooglePayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Google payment of ${amount}");
    }
}