using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Abstraction.Classes;
using Abstraction.Classes.Interfaces;
using Autofac;
using Autofac.Core;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderInfo order = new OrderInfo()
            {
                CustomerName = "Andrii Potapenko",
                ProductName = "--Mac Book Pro--"
            };



            // I still have to instantiate it somewhere ??
            // Commerce commerce = new Commerce(new BillingSystemService(), new LoggerService(), new NotifierService());
            //  commerce.ProcessOrder(order);


            // Create your builder.
            var builder = new ContainerBuilder();

            /**
            Standart style approach
            But what if you have 50 000 000 classes :), write lambda then :)
            */
            //builder.RegisterType<BillingSystemService>().As<IBillingSystemService>();
            //builder.RegisterType<NotifierService>().As<INotifierService>();
            //builder.RegisterType<LoggerService>().As<ILoggerService>();

            /**
            DI Container, could you register all classes which ends with 'Service' word, 
            Take it's interface and Check is name of interface equal I + name of class which ends with word Service
            i.e. SystemService -> getInterface -> is interface name equal ISystemService
            */
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(t => t.Name.EndsWith("Service"))
                .As(t => t.GetInterfaces().FirstOrDefault(inter => inter.Name == "I" + t.Name));


            Container container = builder.Build() as Container;

            // Even this new can be eliminated by adding Commerce to container
            Commerce commerce2 = new Commerce(container.Resolve<IBillingSystemService>(), container.Resolve<ILoggerService>(), container.Resolve<INotifierService>());
            commerce2.ProcessOrder(order);

            Console.ReadKey();
        }



    }
}




















