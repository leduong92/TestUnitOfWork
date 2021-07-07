using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SimplCommerce.Infrastructure;
using SimplCommerce.Infrastructure.Modules;

namespace Test.Module.Region
{
    public class ModuleInitializer : IModuleInitializer
    {

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            throw new NotImplementedException();
        }

        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            GlobalConfiguration.RegisterAngularModule("test.region");
        }
    }
}
