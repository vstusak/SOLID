using Microsoft.Extensions.DependencyInjection;
using SOLID.Communication;
using SOLID.Factories;
using SOLID.Logger;
using SOLID.Providers;

namespace SOLID
{
    class Program
    {
        public static void Main(string[] args)
        {
            var provider = DIContainer.InitiateContainerWithServices();
            var startup = new Startup(
                provider.GetService<ICalculatorProvider>(),
                provider.GetService<ILogger>(),
                provider.GetService<IMessageProvider>(),
                provider.GetService<ICommunication>(),
                provider.GetService<ICalculationStrategyFactory>());

            startup.Run();
        }
    }
}