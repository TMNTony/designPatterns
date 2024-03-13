namespace DesignPatterns.factory;

public class PaymentFactory
{
    public static IPayment create(PaymentMethod method)
    {
        switch (method)
        {
            case PaymentMethod.CreditCard:
                return new CreditCardPayment();
            case PaymentMethod.Google:
                return new GooglePayment();
            case PaymentMethod.PayPal:
                return new PayPalPayment();
            default:
                throw new NotSupportedException(
                    $"{method} is not supported");
        }
    }
}