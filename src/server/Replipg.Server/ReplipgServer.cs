using Replipg.Server.Core.Abstractions;

namespace Replipg.Server;

internal sealed class ReplipgServer : IReplipgServer
{
    public Task StartAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
