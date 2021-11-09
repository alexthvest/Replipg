using Microsoft.Extensions.DependencyInjection;
using Replipg.Core.Hosting;
using Replipg.Server.Core;

namespace Replipg.Server;

internal sealed class ReplipgModule : IReplipgModule
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddServerCore<ReplipgServer>();
    }
}
