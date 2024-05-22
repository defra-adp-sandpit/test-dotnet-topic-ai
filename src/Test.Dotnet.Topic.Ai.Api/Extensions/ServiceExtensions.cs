using Test.Dotnet.Topic.Ai.Core.Interfaces;
using Test.Dotnet.Topic.Ai.Core.Services;

namespace Test.Dotnet.Topic.Ai.Api.Extensions;
public static class ServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddTransient<IItemService, ItemService>();
        return services;
    }
}
