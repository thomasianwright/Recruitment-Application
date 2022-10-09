using Microsoft.Extensions.DependencyInjection;
using Recruitment.Api.Services.Services;

namespace Recruitment.Api.Services.Extensions;

public static class ApiServicesExtensions
{
    public static IServiceCollection AddApiServices(this IServiceCollection sc)
    {
        sc.AddScoped<IPostService, PostService>();
        
        return sc;
    }
}