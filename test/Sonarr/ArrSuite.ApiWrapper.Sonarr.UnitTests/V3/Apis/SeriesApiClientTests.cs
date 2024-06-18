using ArrSuite.ApiWrapper.Sonarr.V3;
using ArrSuite.ApiWrapper.Tests.Common;

namespace ArrSuite.ApiWrapper.Sonarr.UnitTests.V3.Apis;

public class SeriesApiClientTests
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
        
        var result = await client.Series.Get(cancellationToken: cancellationToken);
        
        Assert.Null(result);
    }
    
    [Fact]
    public async Task CancelOfGetWithIdExpectNullResult()
    {
        var cancellationTokenSource = new CancellationTokenSource();
        var cancellationToken = cancellationTokenSource.Token;
        await cancellationTokenSource.CancelAsync();

        var client = new SonarrClient(
            TestConstants.ValidParameters.Url,
            TestConstants.ValidParameters.ApiKey);
        
        var result = await client.Series.Get(1, cancellationToken: cancellationToken);
        
        Assert.Null(result);
    }
}
