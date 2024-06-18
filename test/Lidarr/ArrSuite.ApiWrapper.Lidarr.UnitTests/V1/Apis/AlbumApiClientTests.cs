using ArrSuite.ApiWrapper.Lidarr.V1;
using ArrSuite.ApiWrapper.Tests.Common;

namespace ArrSuite.ApiWrapper.Lidarr.UnitTests.V1.Apis;

public class AlbumApiClientTests
{
    [Fact]
    public async Task CancelOfGetExpectNullResult()
    {
        var cancellationTokenSource = new CancellationTokenSource();
        var cancellationToken = cancellationTokenSource.Token;
        await cancellationTokenSource.CancelAsync();

        var client = new LidarrClient(TestConstants.ValidParameters.Url, TestConstants.ValidParameters.ApiKey);
        var result = await client.Albums.Get(cancellationToken: cancellationToken);
        Assert.Null(result);
    }
    
    [Fact]
    public async Task CancelOfGetWithIdExpectNullResult()
    {
        var cancellationTokenSource = new CancellationTokenSource();
        var cancellationToken = cancellationTokenSource.Token;
        await cancellationTokenSource.CancelAsync();

        var client = new LidarrClient(
            TestConstants.ValidParameters.Url,
            TestConstants.ValidParameters.ApiKey);
        
        var result = await client.Albums.Get(1, cancellationToken: cancellationToken);
        
        Assert.Null(result);
    }
}
