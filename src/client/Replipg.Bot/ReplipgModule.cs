using Microsoft.Extensions.DependencyInjection;
using Replikit.Abstractions.Adapters.Loader;
using Replikit.Adapters.Telegram;
using Replikit.Core.Modules;

namespace Replipg.Bot;

internal class ReplipgModule : ReplikitModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
    }

    public override void ConfigureAdapters(IAdapterLoaderOptions options)
    {
        options.AddTelegram();
    }
}
