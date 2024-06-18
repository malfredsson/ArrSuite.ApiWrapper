using ArrSuite.ApiWrapper.Lidarr.V1.Clients;

namespace ArrSuite.ApiWrapper.Lidarr.V1;

/// <summary>
/// Creates a new API client for accessing Lidarr
/// </summary>
/// <param name="url">The url to the Lidarr instance</param>
/// <param name="apiKey">The api key used for accessing Lidarr</param>
public sealed class LidarrClient(string url, string apiKey)
{
    public AlbumApiClient Albums { get; } = new(url, apiKey);
    public AlbumLookupApiClient AlbumLookup { get; } = new(url, apiKey);
}
