using ArrSuite.ApiWrapper.Radarr.V3;
using ArrSuite.ApiWrapper.Tests.Common;

namespace ArrSuite.ApiWrapper.Radarr.IntegrationTests.V3.Apis.Movie;

public class MovieLookupTests
{
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public async Task EmptyTermParameterExpectNullResult(string emptyTerm)
    {
        var radarrClient = new RadarrClient(TestConstants.Urls.RadarrUrl, TestConstants.ApiKeys.RadarrApiKey);
        var lookupResult = await radarrClient.MovieLookup.TermLookup(emptyTerm, cancellationToken: CancellationToken.None);
        Assert.Null(lookupResult);
    }
    
    [Fact]
    public async Task SuccessfulTermLookupExpectNonNullResult()
    {
        var radarrClient = new RadarrClient(TestConstants.Urls.RadarrUrl, TestConstants.ApiKeys.RadarrApiKey);
        var lookupResult = await radarrClient.MovieLookup.TermLookup("star wars", cancellationToken: CancellationToken.None);
        Assert.NotNull(lookupResult);
    }
    
    [Fact]
    public async Task EmptyImdbIdParameterExpectNullResult()
    {
        var radarrClient = new RadarrClient(TestConstants.Urls.RadarrUrl, TestConstants.ApiKeys.RadarrApiKey);
        var lookupResult = await radarrClient.MovieLookup.ImdbLookup(string.Empty, cancellationToken: CancellationToken.None);
        Assert.Null(lookupResult);
    }
    
    [Fact]
    public async Task SuccessfulImdbLookupExpectNonNullResult()
    {
        var radarrClient = new RadarrClient(TestConstants.Urls.RadarrUrl, TestConstants.ApiKeys.RadarrApiKey);
        var lookupResult = await radarrClient.MovieLookup.ImdbLookup("tt0076759", cancellationToken: CancellationToken.None);
        Assert.NotNull(lookupResult);
    }
    
    [Fact]
    public async Task EmptyTmdbIdParameterExpectNullResult()
    {
        var radarrClient = new RadarrClient(TestConstants.Urls.RadarrUrl, TestConstants.ApiKeys.RadarrApiKey);
        var lookupResult = await radarrClient.MovieLookup.TmdbLookup(string.Empty, cancellationToken: CancellationToken.None);
        Assert.Null(lookupResult);
    }
    
    [Fact]
    public async Task SuccessfulTmdbLookupExpectNonNullResult()
    {
        var radarrClient = new RadarrClient(TestConstants.Urls.RadarrUrl, TestConstants.ApiKeys.RadarrApiKey);
        var lookupResult = await radarrClient.MovieLookup.TmdbLookup("11", cancellationToken: CancellationToken.None);
        Assert.NotNull(lookupResult);
    }
}
