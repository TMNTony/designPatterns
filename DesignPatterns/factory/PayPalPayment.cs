namespace DesignPatterns.factory;

public class PayPalPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paypal payment of ${amount}");
    }
}