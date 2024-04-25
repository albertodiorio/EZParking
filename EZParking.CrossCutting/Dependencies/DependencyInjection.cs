using EzParking.Infrastructure.Context;
using EzParking.Infrastructure.Repositories;
using EZParking.Core.Models;
using EZParking.Domain.ParkingLots.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            services.AddScoped(typeof(IGenericRepository<>), typeof(Repository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            //services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            //services.AddScoped<ICarroRepository, CarroRepository>();
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
    }
}
