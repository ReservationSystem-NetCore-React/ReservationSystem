using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            //services.AddFluentValidationAutoValidation(config =>
            //{
            //    config.DisableDataAnnotationsValidation = true;
            //});

            //services.AddFluentValidationClientsideAdapters();

            return services;
        }
    }
}
