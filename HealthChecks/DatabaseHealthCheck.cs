using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace HealthChecks;
public class DatabaseHealthCheck : IHealthCheck
{
    public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
    {
        bool isHealthy = await IsDatabaseConnectionOkAsync();
        return isHealthy 
            ? HealthCheckResult.Healthy("Database connection is OK")
            : HealthCheckResult.Unhealthy("Database connection ERROR");
    }
    private Task<bool> IsDatabaseConnectionOkAsync()
    {
        return Task.FromResult(DateTime.Now.Millisecond % 2 == 0);
    }
}
