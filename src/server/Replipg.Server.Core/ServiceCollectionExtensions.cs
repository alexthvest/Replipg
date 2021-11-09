using Microsoft.Extensions.DependencyInjection;
using Replipg.Server.Core.Abstractions;

namespace Replipg.Server.Core;

public static class ServiceCollectionExtensions
{
    public static void AddServerCore<TServer>(this IServiceCollection services) 
        where TServer : class, IReplipgServer
    {
        services.AddSingleton<IReplipgServer, TServer>();
        services.AddHostedService<ReplipgHostedService>();
    }
}
