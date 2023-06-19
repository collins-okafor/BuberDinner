using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuberDinner.Application.Authentication.Commands.Register;
using BuberDinner.Application.Common.Behaviors;
using BuberDinner.Application.Services.Authentication.Common;
using ErrorOr;
using MediatR;
using Microsoft.Extensions.DependencyInjection;


namespace BuberDinner.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
        
            services.AddMediatR(typeof(DependencyInjection).Assembly);
            services.AddScoped<IPipelineBehavior<RegisterCommand, ErrorOr<AuthenticationResult>>, ValidateRegisterCommandBehavior>();
            return services;
        }
    }
}