using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Classes
{
    class Commerce
    {
        BillingSystem _billingSystem;
        Logger _logger;
        Notifier _notifier;

        // Drawbacks??
        // Impossible to test without instantiating 4 classes
        public Commerce()
        {
            _billingSystem = new BillingSystem();
            _logger = new Logger();
            _notifier = new Notifier();
        }

        public void ProcessOrder(OrderInfo orderInfo)
        {
            // NOT Semantic approach 
            _billingSystem.ProcessPayment(orderInfo.CustomerName, orderInfo.ProductName, 50);
            // Semantic approach 
            _billingSystem.ProcessPayment(orderInfo.CustomerName, orderInfo.ProductName, Dollars.Amount(50));

            _logger.Log("Payment success");
            _notifier.SendReceipt(orderInfo);
            _logger.Log("Receipt sent");
        }
    }
}