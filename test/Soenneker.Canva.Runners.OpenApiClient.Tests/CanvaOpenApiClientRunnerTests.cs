using Soenneker.Tests.HostedUnit;

namespace Soenneker.Canva.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class CanvaOpenApiClientRunnerTests : HostedUnitTest
{
    public CanvaOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
