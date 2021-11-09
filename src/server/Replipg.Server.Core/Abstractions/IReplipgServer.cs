namespace Replipg.Server.Core.Abstractions;

public interface IReplipgServer
{
    Task StartAsync(CancellationToken cancellationToken);

    Task StopAsync(CancellationToken cancellationToken);
}
