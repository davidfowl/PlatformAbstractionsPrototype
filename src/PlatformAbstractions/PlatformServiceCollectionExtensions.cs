using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.PlatformAbstractions;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class PlatformServiceCollectionExtensions
    {
        public static IServiceCollection AddPlatformAbstractions(this IServiceCollection services)
        {
            services.AddInstance(PlatformServices.Default.Application);
            services.AddInstance(PlatformServices.Default.Runtime);
            return services;
        }
    }
}
