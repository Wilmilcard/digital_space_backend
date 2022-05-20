using DigitalSpaceBN.Interfaces;
using DigitalSpaceBN.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalSpaceBN
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCustomizedServices(this IServiceCollection services)
        {
            services.AddTransient<IPersonServices, PersonServices>();

            return services;
        }
    }
}
