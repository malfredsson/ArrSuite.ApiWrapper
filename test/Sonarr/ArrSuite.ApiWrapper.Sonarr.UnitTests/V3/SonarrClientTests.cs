using ArrSuite.ApiWrapper.Sonarr.V3;
using ArrSuite.ApiWrapper.Tests.Common;

namespace ArrSuite.ApiWrapper.Sonarr.UnitTests.V3;

public class SonarrClientTests
{
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void EmptyOrNullUrlParameterExpectException(string emptyUrl)
    {
        var exception = Assert.Throws<ArgumentNullException>(() => new SonarrClient(
            emptyUrl,
            TestConstants.ValidParameters.ApiKey));

        Assert.Equal("Value cannot be null. (Parameter 'url')", exception.Message);
    }
    
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void EmptyOrNullApiKeyParameterExpectException(string emptyApiKey)
    {
        var exception = Assert.Throws<ArgumentNullException>(() => new SonarrClient(TestConstants.ValidParameters.Url, emptyApiKey));

        Assert.Equal("Value cannot be null. (Parameter 'apiKey')", exception.Message);
    }
    
    [Fact]
    public void EmptyProtocolInUrlParameterExpectException()
    {
        const string urlWithoutProtocol = "127.0.0.1";

        var exception = Assert.Throws<ArgumentException>(() => new SonarrClient(
            urlWithoutProtocol,
            TestConstants.ValidParameters.ApiKey));
        
        Assert.Equal("Parameter url must start with \"http://\" or \"https://\"", exception.Message);
    }
    
    [Fact]
    public void ValidParametersExpectApiPropertiesNotNull()
    {
        var client = new SonarrClient(
            TestConstants.ValidParameters.Url,
            TestConstants.ValidParameters.ApiKey);
        
        Assert.NotNull(client.Calendar);
        Assert.NotNull(client.Series);
    }
}
