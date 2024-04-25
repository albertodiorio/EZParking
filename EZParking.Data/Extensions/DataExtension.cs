using EZParking.Core.Models;
using EZParking.Data.Context;
using EZParking.Data.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using EZParking.Domain.ParkingLots.Abstractions;

namespace EZParking.Data.Extensions
{
    public static class DataExtension
    {
        public static IServiceCollection AddEntityFramework(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            //services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            //services.AddScoped<ICarroRepository, CarroRepository>();
            return services;
        }
    }
}
