using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplication1.Services;
using Xunit.Microsoft.DependencyInjection;
using Xunit.Microsoft.DependencyInjection.Abstracts;

namespace WebApplication1.TestProject1;

public class GlobalTestFixture : TestBedFixture
{
    protected override void AddServices(IServiceCollection services, IConfiguration? configuration)
    {
        var builder = WebApplication.CreateBuilder();

        var app = builder.Build();

        services.AddSingleton<IConfiguration>(builder.Configuration);
        services.AddScoped<IConfigurationService, ConfigurationService>();
    }

    protected override ValueTask DisposeAsyncCore()
    {
        return new();
    }

    protected override IEnumerable<TestAppSettings> GetTestAppSettings()
    {
        yield return new();
    }
}
