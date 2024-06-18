using ArrSuite.ApiWrapper.Sonarr.V3;
using ArrSuite.ApiWrapper.Tests.Common;

namespace ArrSuite.ApiWrapper.Sonarr.UnitTests.V3.Apis;

public class SeriesLookupApiClientTests
{
    [Fact]
    public async Task CancelOfGetExpectNullResult()
    {
        var cancellationTokenSource = new CancellationTokenSource();
        var cancellationToken = cancellationTokenSource.Token;
        await cancellationTokenSource.CancelAsync();

        var client = new SonarrClient(
            TestConstants.ValidParameters.Url,
            TestConstants.ValidParameters.ApiKey);
        
        var result = await client.Lookup.TermLookup("term", cancellationToken: cancellationToken);
        
        Assert.Null(result);
    }
}
