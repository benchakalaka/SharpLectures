using Abstraction.Classes.Interfaces;
using Abstraction.Classes.Semantic;

namespace Abstraction.Classes
{
    public class Commerce
    {
        IBillingSystemService _billingSystem;
        ILoggerService _logger;
        private INotifierService _notifier;

        public Commerce(IBillingSystemService billingSystem, ILoggerService logger, INotifierService notifier)
        {
            _billingSystem = billingSystem;
            _logger = logger;
            _notifier = notifier;
        }

        public void ProcessOrder(OrderInfo orderInfo)
        {
            // Semantic approach ?
            // _billingSystem.ProcessPayment(orderInfo.CustomerName, orderInfo.ProductName, 50);

            // Semantic approach
            _billingSystem.ProcessPayment(orderInfo.CustomerName, orderInfo.ProductName, Dollars.Amount(50));
            //
            //            balancl.Account -= 50;
            //            balancl.Withdraw(Dollars.Amount(50));
            //
            //            Hotspot h;
            //
            //            h.X = -100;
            //            h.Y = -100;
            //
            //            h.setInvisible();
            //            h.setUnassigned();

            _logger.Log("Payment success");
            _notifier.SendReceipt(orderInfo);
            _logger.Log("Receipt sent");
        }
    }
}



















// 1) It's a hosting class, it's doesn't know is it implementation, is it fake (Mocks)
//











// 1) Impossible to test without instantiating 4 other classes
// 2) DON'T DO ----- new YouObjectName() ---- INSIDE YOUR CLASSES
// 3) 






//_billingSystem.ProcessPayment(orderInfo.CustomerName, orderInfo.ProductName, Dollars.Amount(50));
