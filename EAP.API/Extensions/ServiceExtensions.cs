using EAP.Contracts.IRepositoty.AddressRepo;
using EAP.Contracts.IRepositoty.LoggerManager;
using EAP.Contracts.IRepositoty.OccupationRepo;
using EAP.Contracts.IRepositoty.OrganizationsRepo;
using EAP.Contracts.IRepositoty.Wrapper;
using EAP.Entity.Data;
using EAP.Repository.Repo.AddressRepo;
using EAP.Repository.Repo.LoggerManager;
using EAP.Repository.Repo.OccupationRepo;
using EAP.Repository.Repo.Organizations;
using EAP.Repository.Repo.Wrapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EAP.API.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCore(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });
        }
        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>
            {

            });
        }
        public static void ConfigureSqlConnection(this IServiceCollection services,
            IConfiguration config)
        {
            var connectionString = config["DefaultConnection:connectionString"];
            services.AddDbContext<EAPDbContext>(options =>
                options.UseSqlServer(connectionString,
                    options => options.MigrationsAssembly("EAP.API")
                )
            );
        }
        public static void ConfigureRepoWrapper(this IServiceCollection services)
        {
            services.AddScoped<IWrapperRepo, WrapperRepo>();
            services.AddScoped<IDistrictsRepo, DistrictsRepo>();
            services.AddScoped<IMunicipalitiesRepo, MunicipalitiesRepo>();
            services.AddScoped<IOccupationsRepo, OccupationsRepo>();
            services.AddScoped<IOrganizationTypesRepo, OrganizationTypesRepo>();
        }
    }
}