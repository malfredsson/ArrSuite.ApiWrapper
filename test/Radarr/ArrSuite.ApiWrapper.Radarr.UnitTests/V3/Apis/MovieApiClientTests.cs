using ArrSuite.ApiWrapper.Radarr.V3;
using ArrSuite.ApiWrapper.Tests.Common;

namespace ArrSuite.ApiWrapper.Radarr.UnitTests.V3.Apis;

public class MovieApiClientTests
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

        var result = await client.Movies.Get(cancellationToken: cancellationToken);

        Assert.Null(result);
    }
    
    [Fact]
    public async Task CancelOfGetWithIdExpectNullResult()
    {
        var cancellationTokenSource = new CancellationTokenSource();
        var cancellationToken = cancellationTokenSource.Token;
        await cancellationTokenSource.CancelAsync();

        var client = new RadarrClient(
            TestConstants.ValidParameters.Url,
            TestConstants.ValidParameters.ApiKey);
        
        var result = await client.Movies.Get(1, cancellationToken: cancellationToken);
        
        Assert.Null(result);
    }
}
