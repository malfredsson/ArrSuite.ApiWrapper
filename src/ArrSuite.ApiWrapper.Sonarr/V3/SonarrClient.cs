using ArrSuite.ApiWrapper.Sonarr.V3.Clients;

namespace ArrSuite.ApiWrapper.Sonarr.V3;

/// <summary>
/// Creates a new API client for accessing Sonarr
/// </summary>
/// <param name="url">The url to the Sonarr instance</param>
/// <param name="apiKey">The api key used for accessing Sonarr</param>
public sealed class SonarrClient(string url, string apiKey)
{
    public CalendarApiClient Calendar { get; } = new(url, apiKey);
    public SeriesApiClient Series { get; } = new(url, apiKey);
    public SeriesLookupApiClient Lookup { get; } = new(url, apiKey);
}
