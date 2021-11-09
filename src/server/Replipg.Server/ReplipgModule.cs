using Microsoft.Extensions.DependencyInjection;
using Replipg.Core.Hosting;
using Replipg.Server.Core;

namespace Replipg.Server;

public sealed class ReplipgModule : IReplipgModule
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddServerCore();
    }
}
