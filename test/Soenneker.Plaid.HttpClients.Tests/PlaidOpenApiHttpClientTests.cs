using Soenneker.Plaid.HttpClients.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Plaid.HttpClients.Tests;

[Collection("Collection")]
public sealed class PlaidOpenApiHttpClientTests : FixturedUnitTest
{
    private readonly IPlaidOpenApiHttpClient _httpclient;

    public PlaidOpenApiHttpClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _httpclient = Resolve<IPlaidOpenApiHttpClient>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
