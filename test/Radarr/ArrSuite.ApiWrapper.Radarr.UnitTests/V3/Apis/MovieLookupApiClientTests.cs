using ArrSuite.ApiWrapper.Radarr.V3;
using ArrSuite.ApiWrapper.Tests.Common;

namespace ArrSuite.ApiWrapper.Radarr.UnitTests.V3.Apis;

public class MovieLookupApiClientTests
{
    [Fact]
    public async Task CancelOfGetExpectNullResult()
    {
        var cancellationTokenSource = new CancellationTokenSource();
        var cancellationToken = cancellationTokenSource.Token;
        await cancellationTokenSource.CancelAsync();

        var client = new RadarrClient(
            TestConstants.ValidParameters.Url,
            TestConstants.ValidParameters.ApiKey);

        var result = await client.MovieLookup.TermLookup("term", cancellationToken: cancellationToken);
        
        Assert.Null(result);
    }
}
