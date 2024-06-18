using ArrSuite.ApiWrapper.Sonarr.V3.Apis;
using ArrSuite.ApiWrapper.Sonarr.V3.Models;
using ArrSuite.ApiWrapper.V3;
using Refit;

namespace ArrSuite.ApiWrapper.Sonarr.V3.Clients;

public sealed class SeriesApiClient : ArrSuiteV3ApiClient
{
    private readonly ISeriesApi _api;

    internal SeriesApiClient(string url, string apiKey) : base(url, apiKey)
    {
        _api = RestService.For<ISeriesApi>(Url);
    }

    /// <summary>
    /// Get all added series
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A collection of all added series</returns>
    public async Task<IReadOnlyCollection<Series>?> Get(CancellationToken cancellationToken = default)
    {
        if (cancellationToken.IsCancellationRequested)
        {
            return null;
        }

        var response = await _api.Series(ApiKey, cancellationToken);

        return !response.IsSuccessStatusCode ? null : response.Content;
    }

    /// <summary>
    /// Gets a single added series by its id
    /// </summary>
    /// <param name="id">The id of the series to get</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A single series which matches the supplied id</returns>
    public async Task<Series?> Get(long id, CancellationToken cancellationToken = default)
    {
        if (cancellationToken.IsCancellationRequested)
        {
            return null;
        }

        var response = await _api.Series(id, ApiKey, cancellationToken);

        return !response.IsSuccessStatusCode ? null : response.Content;
    }
}
