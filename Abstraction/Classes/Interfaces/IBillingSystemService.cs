namespace Abstraction.Classes.Interfaces
{
    public interface IBillingSystemService
    {
        void ProcessPayment(string customer, string productName, double price);
    }
}