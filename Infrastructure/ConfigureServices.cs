using Infrastructure.Database;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;
public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(
        this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ProwitechDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("ProwitechConnection")));
       
        services.AddScoped<IUsersRepository, UsersRepository>();
        services.AddScoped<IRoleRepository, RoleRepository>();
        services.AddScoped<IPermissionsRepository, PermissionRepository>();
        services.AddScoped<IBuildingAddressRepository, BuildingAddressRepository>();
        services.AddScoped<IFullAddressRepository, FullAddressRepository>();
        services.AddScoped<IPropertyManagerRepository, PropertyManagerRepository>();
        services.AddScoped<IBuildingRepository, BuildingRepository>();

        return services;
    }
}
