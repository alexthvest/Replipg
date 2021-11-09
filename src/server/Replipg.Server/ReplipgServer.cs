using Replipg.Server.Core.Abstractions;

namespace Replipg.Server;

public sealed class ReplipgServer : IReplipgServer
{
    public Task StartAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
