using Soenneker.Plaid.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Plaid.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class PlaidOpenApiHttpClientTests : HostedUnitTest
{
    private readonly IPlaidOpenApiHttpClient _httpclient;

    public PlaidOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<IPlaidOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
