using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuberDinner.Application.Services.Authentication;
using BuberDinner.Application.Services.Commands.Authentication;
using BuberDinner.Application.Services.Queries.Authentication;
using Microsoft.Extensions.DependencyInjection;


namespace BuberDinner.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationQueryService, AuthenticationQueryService>();
            services.AddScoped<IAuthenticationCommandService, AuthenticationCommandService>();

            return services;
        }
    }
}