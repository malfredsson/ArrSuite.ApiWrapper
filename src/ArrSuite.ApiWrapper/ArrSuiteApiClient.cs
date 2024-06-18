namespace ArrSuite.ApiWrapper;

public abstract class ArrSuiteApiClient
{
    protected ArrSuiteApiClient(string url, string apiVersion, string apiKey)
    {
        if (string.IsNullOrWhiteSpace(url))
        {
            throw new ArgumentNullException(nameof(url));
        }
        
        if (string.IsNullOrWhiteSpace(apiKey))
        {
            throw new ArgumentNullException(nameof(apiKey));
        }
        
        url = url.Trim();
        apiKey = apiKey.Trim();

        if (!url.StartsWith("http://") &&
            !url.StartsWith("https://"))
        {
            throw new ArgumentException($"Parameter {nameof(url)} must start with \"http://\" or \"https://\"");
        }
        
        if (url.EndsWith('/'))
        {
            url = url[..^1];
        }

        if (string.IsNullOrWhiteSpace(apiVersion))
        {
            throw new ArgumentNullException(nameof(apiVersion));
        }

        Url = $"{url}/api/{apiVersion}";
        ApiKey = apiKey;
    }

    protected string ApiKey { get; }
    protected string Url { get; }
}