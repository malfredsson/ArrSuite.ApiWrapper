using ArrSuite.ApiWrapper.Lidarr.V1.Apis;
using ArrSuite.ApiWrapper.Lidarr.V1.Models;
using ArrSuite.ApiWrapper.V1;
using Refit;

namespace ArrSuite.ApiWrapper.Lidarr.V1.Clients;

public sealed class AlbumLookupApiClient: ArrSuiteV1ApiClient
{
    private readonly IAlbumLookupApi _api;

    internal AlbumLookupApiClient(string url, string apiKey) : base(url, apiKey)
    {
        _api = RestService.For<IAlbumLookupApi>(Url);
    }
    
    /// <summary>
    /// Lookup albums using a search term
    /// </summary>
    /// <param name="term">The search term</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Found albums matching the search term supplied</returns>
    public async Task<IReadOnlyCollection<Album>?> TermLookup(string term, CancellationToken cancellationToken = default)
    {
        if (cancellationToken.IsCancellationRequested)
        {
            return null;
        }

        var response = await _api.TermLookup(term, ApiKey, cancellationToken);

        return !response.IsSuccessStatusCode ? null : response.Content;
    }
}
