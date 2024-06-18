using ArrSuite.ApiWrapper.Radarr.V3.Clients;

namespace ArrSuite.ApiWrapper.Radarr.V3;

/// <summary>
/// Creates a new API client for accessing Radarr
/// </summary>
/// <param name="url">The url to the Radarr instance</param>
/// <param name="apiKey">The api key used for accessing Radarr</param>
public sealed class RadarrClient(string url, string apiKey)
{
    public MovieLookupApiClient MovieLookup { get; } = new(url, apiKey);
    public MovieApiClient Movies { get; } = new(url, apiKey);
}
