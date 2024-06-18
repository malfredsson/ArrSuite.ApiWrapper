using ArrSuite.ApiWrapper.Lidarr.V1;

namespace ArrSuite.ApiWrapper.Lidarr.UnitTests.V1;

public class LidarrClientTests
{
    private const string ValidApiKey = "someApiKey";
    private const string ValidUrl = "http://127.0.0.1";
    
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void EmptyOrNullUrlParameterExpectException(string emptyUrl)
    {
        var exception = Assert.Throws<ArgumentNullException>(() => new LidarrClient(emptyUrl, ValidApiKey ));
        Assert.Equal("Value cannot be null. (Parameter 'url')", exception.Message);
    }
    
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void EmptyOrNullApiKeyParameterExpectException(string emptyApiKey)
    {
        var exception = Assert.Throws<ArgumentNullException>(() => new LidarrClient(ValidUrl, emptyApiKey));
        Assert.Equal("Value cannot be null. (Parameter 'apiKey')", exception.Message);
    }
    
    [Fact]
    public void EmptyProtocolInUrlParameterExpectException()
    {
        const string urlWithoutProtocol = "127.0.0.1";
        var exception = Assert.Throws<ArgumentException>(() => new LidarrClient(urlWithoutProtocol, ValidApiKey ));
        Assert.Equal("Parameter url must start with \"http://\" or \"https://\"", exception.Message);
    }
    
    [Fact]
    public void ValidParametersExpectApiPropertiesNotNull()
    {
        var client = new LidarrClient(ValidUrl, ValidApiKey);
        Assert.NotNull(client.Albums);
        Assert.NotNull(client.AlbumLookup);
    }
}
