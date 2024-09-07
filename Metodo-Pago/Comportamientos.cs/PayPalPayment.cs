public class PayPalPayment : IPaymentStrategy
{
    private string email { get; set; }

    public PayPalPayment(string email)
    {
        this.email = email;
    }
    public void Pay(double amount)
    {
        Console.WriteLine($"Pagando {amount} con PayPal, cuenta: {email}");
    }
}