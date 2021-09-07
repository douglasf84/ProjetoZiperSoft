
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ProjetoZiperSoft
{
   public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            /*
            services.AddDbContext<DataContext>(options =>
            options.UseMySql(configuration.GetConnectionString("DefaultConnection"),
            ServerVersion.AutoDetect)))));
            */

            string stringConexao = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<DataContext>(options => options.UseMySql(stringConexao, ServerVersion.AutoDetect(stringConexao)));

            services.AddScoped<IClientePFRepository, ClientePFRepository>();
            services.AddScoped<IClientePJRepository, ClientePJRepository>();
            services.AddScoped<IEnderecoRepoitory, EnderecoRepository>();

            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            return services;
        }
    }
}
