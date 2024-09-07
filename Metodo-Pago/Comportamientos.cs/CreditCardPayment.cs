public class CreditCardPayment : IPaymentStrategy
{
    private string cardNumber { get; set; }
    private string cardHolderName { get; set; }

    public CreditCardPayment(string cardNumber, string cardHolderName)
    {
        this.cardNumber = cardNumber;
        this.cardHolderName = cardHolderName;
    }
    public void Pay(double amount)
    {
        Console.WriteLine($"pagado {amount} con la tarjeta de crédito: {cardNumber}, a nombre de {cardHolderName}");
    }
}
