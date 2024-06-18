using ArrSuite.ApiWrapper.Lidarr.V1;
using ArrSuite.ApiWrapper.Tests.Common;

namespace ArrSuite.ApiWrapper.Lidarr.UnitTests.V1.Apis;

public class AlbumLookupApiClientTests
{
    [Fact]
    public async Task CancelOfGetExpectNullResult()
    {
        var cancellationTokenSource = new CancellationTokenSource();
        var cancellationToken = cancellationTokenSource.Token;
        await cancellationTokenSource.CancelAsync();

        var client = new LidarrClient(
            TestConstants.ValidParameters.Url,
            TestConstants.ValidParameters.ApiKey);
        
        var result = await client.AlbumLookup.TermLookup("term", cancellationToken: cancellationToken);
        
        Assert.Null(result);
    }
}
