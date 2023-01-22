using Infrastructure.Database;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Interfaces.UnitOfWork;
using Infrastructure.Models.Domain;
using Infrastructure.Repositories;
using Infrastructure.UnitOfWork;
using Microsoft.AspNetCore.Identity;
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
       
        services.AddScoped<IRepositoriesUnitOfWork, RepositoriesUnitOfWork>();
        services.AddScoped<IBuildingAddressRepository, BuildingAddressRepository>();
        services.AddScoped<IPropertyAddressRepository, PropertyAddressRepository>();
        services.AddScoped<IFullAddressRepository, FullAddressRepository>();
        services.AddScoped<IPropertyManagerRepository, PropertyManagerRepository>();
        services.AddScoped<IBuildingRepository, BuildingRepository>();
        services.AddScoped<IRealPropertyRepository, RealPropertyRepository>();
        services.AddScoped<IInspectionTaskRepository, InspectionTaskRepository>();
        services.AddScoped<IInspectionProtocolsRepository, InspectionProtocolsRepository>();

        services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();


        return services;
    }
}
