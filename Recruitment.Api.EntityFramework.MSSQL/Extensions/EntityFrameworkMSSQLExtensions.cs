using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Recruitment.Api.Abstractions.Contracts;
using Recruitment.Api.EntityFramework.MSSQL.Data;
using Recruitment.Api.EntityFramework.MSSQL.Repositories;

namespace Recruitment.Api.EntityFramework.MSSQL.Extensions;

public static class EntityFrameworkMSSQLExtensions
{
    public static IServiceCollection AddEntityFrameworkMSSQLInfrastructure(this IServiceCollection sc, IConfiguration configuration)
    {
        sc.AddScoped<IPostsRepository, PostsRepository>()
            .AddScoped<IAgentRepository, AgentRepository>()
            .AddScoped<IPostsRepository, PostsRepository>();
        
        sc.AddDbContextFactory<ApiContext>(options =>
        {
            options.UseLazyLoadingProxies();
            options.UseSqlServer(configuration.GetConnectionString("ApiConnection"));
        });

        return sc;
    }
}