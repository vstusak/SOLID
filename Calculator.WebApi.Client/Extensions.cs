using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Calculator.WebApi.Client
{
    public class Extensions
    {
        public static IServiceCollection AddCalculatorApiClients(this IServiceCollection services) {

            
            services.AddHttpClient<LocalhostCalculatorApiClient>();

            return services;
        }

 

    }
}
