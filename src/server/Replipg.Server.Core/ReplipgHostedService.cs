using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Replipg.Server.Core.Abstractions;

namespace Replipg.Server.Core;

internal sealed class ReplipgHostedService : IHostedService
{
    private readonly ILogger<ReplipgHostedService> _logger;
    private readonly IReplipgServer _server;

    public ReplipgHostedService(ILogger<ReplipgHostedService> logger, IReplipgServer server)
    {
        _logger = logger;
        _server = server;
    }
    
    public async Task StartAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Server is started");
        
        await _server.StartAsync(cancellationToken);
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Server is stopped");
        
        await _server.StopAsync(cancellationToken);
    }
}
