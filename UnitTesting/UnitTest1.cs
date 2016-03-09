using System;
using Abstraction.Classes;
using Abstraction.Classes.Interfaces;
using DI.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;


namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Mock<IBillingSystemService> mockBilling = new Mock<IBillingSystemService>();
            Mock<ILoggerService> mockLogger = new Mock<ILoggerService>();
            Mock<INotifierService> mockNotifier = new Mock<INotifierService>();

            mockBilling.Setup(obj => obj.ProcessPayment(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()));
            mockLogger.Setup(obj => obj.Log(It.IsAny<string>()));
            mockNotifier.Setup(obj => obj.SendReceipt(It.IsAny<OrderInfo>()));

            Commerce commerce = new Commerce(mockBilling.Object, mockLogger.Object, mockNotifier.Object);

            commerce.ProcessOrder(new OrderInfo());

            Assert.IsTrue(1 == 1); // Perfect test
        }
    }
}

// Give me an interface, create a virtual class for this interface, follow this directions
// I am not hitting any database, I am not sending emails, I am not perform any harm (Run test without any harm)
// !!! Something still has to instantiate this, imagine that process will be longer
// When you add new class you have to start back track, in order to fix test

