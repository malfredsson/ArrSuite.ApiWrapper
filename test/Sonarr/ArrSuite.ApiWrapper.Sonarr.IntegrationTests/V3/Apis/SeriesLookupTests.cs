using ArrSuite.ApiWrapper.Sonarr.V3;
using ArrSuite.ApiWrapper.Tests.Common;

namespace ArrSuite.ApiWrapper.Sonarr.IntegrationTests.V3.Apis;

public class SeriesLookupTests
{
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public async Task EmptyTermParameterExpectNullResult(string emptyTerm)
    {
        var sonarrClient = new SonarrClient(TestConstants.Urls.SonarrUrl, TestConstants.ApiKeys.SonarrApiKey);
        var lookupResult = await sonarrClient.Lookup.TermLookup(emptyTerm, cancellationToken: CancellationToken.None);
        Assert.Null(lookupResult);
    }
    
    [Fact]
    public async Task SuccessfulTermLookupExpectNonNullResult()
    {
        var sonarrClient = new SonarrClient(TestConstants.Urls.SonarrUrl, TestConstants.ApiKeys.SonarrApiKey);
        var lookupResult = await sonarrClient.Lookup.TermLookup("friends", cancellationToken: CancellationToken.None);
        Assert.NotNull(lookupResult);
    }
}