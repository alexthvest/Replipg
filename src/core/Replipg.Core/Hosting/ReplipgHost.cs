using Kantaiko.Hosting.Host;

namespace Replipg.Core.Hosting;

public sealed class ReplipgHost
{
    public static void RunModule<TModule>() where TModule : class, IReplipgModule
    {
        var hostBuilder = new ManagedHostBuilder();
        
        hostBuilder.Modules.Add<TModule>();
        
        hostBuilder.Build().Run();
    }
}
