using Microsoft.Extensions.DependencyInjection;
using SOLID.Communication;
using SOLID.Factories;
using SOLID.Logger;
using SOLID.Providers;
using SOLID.Strategies;

namespace SOLID
{
    public static class DIContainer
    {
        internal static ServiceProvider InitiateContainerWithServices()
        {
            var srvCollection = new ServiceCollection();

            srvCollection.AddSingleton<ICalculatorProvider, CalculatorProvider>();
            srvCollection.AddSingleton<IMessageProvider, ConsoleMessageProvider>();

            srvCollection.AddScoped<ICalculationStrategyFactory, CalculationStrategyFactory>();

            srvCollection.AddTransient<ICalculationStrategy, AddCalculationStrategy>();
            srvCollection.AddTransient<AddCalculationStrategy>();
            srvCollection.AddTransient<ICalculationStrategy, DivideCalculationStrategy>();
            srvCollection.AddTransient<DivideCalculationStrategy>();
            srvCollection.AddTransient<ICalculationStrategy, SubtractCalculationStrategy>();
            srvCollection.AddTransient<SubtractCalculationStrategy>();
            srvCollection.AddTransient<ICalculationStrategy, MultiplyCalculationStrategy>();
            srvCollection.AddTransient<MultiplyCalculationStrategy>();

            srvCollection.AddSingleton<ILogger, JsonLogger>();
            srvCollection.AddSingleton<ICommunication, ConsoleCommunication>();

            return srvCollection.BuildServiceProvider();
        }
    }
}
