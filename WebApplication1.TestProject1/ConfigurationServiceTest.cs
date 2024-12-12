using WebApplication1.Services;
using Xunit.Abstractions;
using Xunit.Microsoft.DependencyInjection.Abstracts;

namespace WebApplication1.TestProject1;

public class ConfigurationServiceTest : TestBed<GlobalTestFixture>
{
    private readonly IConfigurationService _configurationService;

    public ConfigurationServiceTest(ITestOutputHelper testOutputHelper, GlobalTestFixture fixture) : base(testOutputHelper, fixture)
    {
        _configurationService = fixture.GetService<IConfigurationService>(testOutputHelper)!;
    }

    [Fact]
    public void TestGetConnectionString()
    {
        // Arrange

        // Act
        var connectionString = _configurationService.GetConnectionString();
        Console.WriteLine(connectionString);
        // Assert
        Assert.NotNull(connectionString);
        Assert.Equal("Transformed Prd DefaultConnection in appsettings.Production.json", connectionString);
    }
}
