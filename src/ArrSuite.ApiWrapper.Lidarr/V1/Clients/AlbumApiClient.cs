using ArrSuite.ApiWrapper.Lidarr.V1.Apis;
using ArrSuite.ApiWrapper.Lidarr.V1.Models;
using ArrSuite.ApiWrapper.V1;
using Refit;

namespace ArrSuite.ApiWrapper.Lidarr.V1.Clients;

public sealed class AlbumApiClient: ArrSuiteV1ApiClient
{
    private readonly IAlbumApi _api;

    internal AlbumApiClient(string url, string apiKey) : base(url, apiKey)
    {
        _api = RestService.For<IAlbumApi>(Url);
    }
    
    /// <summary>
    /// Get all added albums
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A collection of all added albums</returns>
    public async Task<IReadOnlyCollection<Album>?> Get(CancellationToken cancellationToken = default)
    {
        if (cancellationToken.IsCancellationRequested)
        {
            return null;
        }

        var response = await _api.Get(ApiKey, cancellationToken);

        return !response.IsSuccessStatusCode ? null : response.Content;
    }

    /// <summary>
    /// Gets a single added album by its id
    /// </summary>
    /// <param name="id">The id of the album to get</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A single album which matches the supplied id</returns>
    public async Task<Album?> Get(long id, CancellationToken cancellationToken = default)
    {
        if (cancellationToken.IsCancellationRequested)
        {
            return null;
        }

        var response = await _api.Get(id, ApiKey, cancellationToken);

        return !response.IsSuccessStatusCode ? null : response.Content;
    }
}
