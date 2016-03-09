using Abstraction.Classes.Interfaces;

namespace Abstraction.Classes
{

    public class OrderInfo : IOrderInfoService
    {
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
    }
}
