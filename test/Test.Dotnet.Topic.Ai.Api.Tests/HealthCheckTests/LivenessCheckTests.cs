using Test.Dotnet.Topic.Ai.Api.HealthChecks;

using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Test.Dotnet.Topic.Ai.Api.Tests.HealthChecksTests;

public class LivenessCheckTests
{
    private readonly LivenessCheck _sut = new();

    [Fact]
    public async Task CheckHealthAsync_Returns_Healthy()
    {
        //Arrange
        var mockContext = new HealthCheckContext();
        var cancellationToken = new CancellationToken();

        //Act
        var result = await _sut.CheckHealthAsync(mockContext, cancellationToken);

        //Assert
        result.Should().BeEquivalentTo(HealthCheckResult.Healthy("OK"));
    }
}