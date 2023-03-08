﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddSwaggerExtension(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {                
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "System rezerwacji",                   
                    Contact = new OpenApiContact
                    {
                        Name = "Github",                        
                        Url = new Uri("https://github.com/ZZ-YMT/ReservationSystem"),
                    }
                });  
            });
        }       
    }
}
