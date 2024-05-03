using EZParking.Infrastructure.Context;
using EzParking.Infrastructure.Repositories;
using EZParking.Common.Infra.Services;
using EZParking.Core.DomainObjects;
using EZParking.Domain.ParkingLots.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using EZParking.Common.Validations;
using MediatR;
using FluentValidation;
using System.Reflection;

namespace EZParking.CrossCutting.Dependencies
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IParkingLotRepository, ParkingLotRepository>();
            services.AddScoped<IAddressRepository, AddressRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IMediatorService, MediatorService>();

            return services;
        }

        public static IServiceCollection AddHandlers(this IServiceCollection services)
        {
            var handlers = AppDomain.CurrentDomain.Load("EZParking.Application");

            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblies(handlers);                
            });

            return services;
        }

        public static IServiceCollection AddValidators(this IServiceCollection services)
        {
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationPipelineBehavior<,>));
            services.AddValidatorsFromAssembly(Assembly.Load("EZParking.Common"), includeInternalTypes: true);

            return services;

        }
    }
}
