using ArrSuite.ApiWrapper.Lidarr.V1;
using ArrSuite.ApiWrapper.Tests.Common;

namespace ArrSuite.ApiWrapper.Lidarr.IntegrationTests.V1.Apis.AlbumLookup;

public class AlbumTermLookupTests
{
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public async Task EmptyTermParameterExpectNullResult(string emptyTerm)
    {
        var lidarrClient = new LidarrClient(TestConstants.Urls.LidarrUrl, TestConstants.ApiKeys.LidarrApiKey);
        var lookupResult = await lidarrClient.AlbumLookup.TermLookup(emptyTerm, cancellationToken: CancellationToken.None);
        Assert.Null(lookupResult);
    }
    
    [Fact]
    public async Task SuccessfulLookupExpectNonNullResult()
    {
        var lidarrClient = new LidarrClient(TestConstants.Urls.LidarrUrl, TestConstants.ApiKeys.LidarrApiKey);
        var lookupResult = await lidarrClient.AlbumLookup.TermLookup("u2", cancellationToken: CancellationToken.None);
        Assert.NotNull(lookupResult);
    }
}
