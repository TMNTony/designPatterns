namespace DesignPatterns.factory;

public class CreditCardPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Credit card payment of ${amount}");
    }
}