using ArrSuite.ApiWrapper.Sonarr.V3.Apis;
using ArrSuite.ApiWrapper.Sonarr.V3.Models;
using ArrSuite.ApiWrapper.V3;
using Refit;

namespace ArrSuite.ApiWrapper.Sonarr.V3.Clients;

public sealed class SeriesLookupApiClient : ArrSuiteV3ApiClient
{
    private readonly ISeriesLookupApi _api;

    internal SeriesLookupApiClient(string url, string apiKey) : base(url, apiKey)
    {
        _api = RestService.For<ISeriesLookupApi>(Url);
    }

    /// <summary>
    /// Lookup series using a search term
    /// </summary>
    /// <param name="term">The search term</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Found series matching the search term supplied</returns>
    public async Task<IReadOnlyCollection<Series>?> TermLookup(string term, CancellationToken cancellationToken = default)
    {
        if (cancellationToken.IsCancellationRequested)
        {
            return null;
        }

        var response = await _api.TermLookup(term, ApiKey, cancellationToken);

        return !response.IsSuccessStatusCode ? null : response.Content;
    }
}
