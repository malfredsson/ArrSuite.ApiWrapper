using ArrSuite.ApiWrapper.Radarr.V3;

namespace ArrSuite.ApiWrapper.Radarr.UnitTests.V3;

public class RadarrClientTests
{
    private const string ValidApiKey = "someApiKey";
    private const string ValidUrl = "http://127.0.0.1";
    
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void EmptyOrNullUrlParameterExpectException(string emptyUrl)
    {
        var exception = Assert.Throws<ArgumentNullException>(() => new RadarrClient(emptyUrl, ValidApiKey ));
        Assert.Equal("Value cannot be null. (Parameter 'url')", exception.Message);
    }
    
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void EmptyOrNullApiKeyParameterExpectException(string emptyApiKey)
    {
        var exception = Assert.Throws<ArgumentNullException>(() => new RadarrClient(ValidUrl, emptyApiKey));
        Assert.Equal("Value cannot be null. (Parameter 'apiKey')", exception.Message);
    }
    
    [Fact]
    public void EmptyProtocolInUrlParameterExpectException()
    {
        const string urlWithoutProtocol = "127.0.0.1";
        var exception = Assert.Throws<ArgumentException>(() => new RadarrClient(urlWithoutProtocol, ValidApiKey ));
        Assert.Equal("Parameter url must start with \"http://\" or \"https://\"", exception.Message);
    }
    
    [Fact]
    public void ValidParametersExpectApiPropertiesNotNull()
    {
        var client = new RadarrClient(ValidUrl, ValidApiKey);
        Assert.NotNull(client.Movies);
        Assert.NotNull(client.MovieLookup);
    }
}
