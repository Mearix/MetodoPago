public class ShoppingCart
{
    private IPaymentStrategy paymentStrategy;

    public void SetPaymentStrategy(IPaymentStrategy PaymentStrategy)
    {
        this.paymentStrategy = PaymentStrategy;
    }

    public void Checkout(double amount)
    {
        if (paymentStrategy == null)
        {
            Console.WriteLine("Debe seleccionar un método de pago antes de proceder.");
        }
        else
        {
            paymentStrategy.Pay(amount);
        }
    }
}