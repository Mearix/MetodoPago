class Program
{
    static void Main(string[] args)
    {
        ShoppingCart cart = new ShoppingCart();

        IPaymentStrategy creditCardPayment = new CreditCardPayment("1234-5678-9876-5432", "Juan Santana");
        cart.SetPaymentStrategy(creditCardPayment);
        cart.Checkout(150.00);

        IPaymentStrategy payPalPayment = new PayPalPayment("jujosapla@gmail.com");
        cart.SetPaymentStrategy(payPalPayment);
        cart.Checkout(75.50);
    }
}
