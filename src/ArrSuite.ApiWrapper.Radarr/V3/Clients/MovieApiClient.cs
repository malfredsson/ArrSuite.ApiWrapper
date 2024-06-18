using ArrSuite.ApiWrapper.Radarr.V3.Apis;
using ArrSuite.ApiWrapper.Radarr.V3.Models;
using ArrSuite.ApiWrapper.V3;
using Refit;

namespace ArrSuite.ApiWrapper.Radarr.V3.Clients;

public sealed class MovieApiClient: ArrSuiteV3ApiClient
{
    private readonly IMovieApi _api;

    internal MovieApiClient(string url, string apiKey) : base(url, apiKey)
    {
        _api = RestService.For<IMovieApi>(Url);
    }
    
    /// <summary>
    /// Get all added movies
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A collection of all added movies</returns>
    public async Task<IReadOnlyCollection<Movie>?> Get(CancellationToken cancellationToken = default)
    {
        if (cancellationToken.IsCancellationRequested)
        {
            return null;
        }

        var response = await _api.Get(ApiKey, cancellationToken);

        return !response.IsSuccessStatusCode ? null : response.Content;
    }

    /// <summary>
    /// Gets a single added movie by its id
    /// </summary>
    /// <param name="id">The id of the movie to get</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A single movie which matches the supplied id</returns>
    public async Task<Movie?> Get(long id, CancellationToken cancellationToken = default)
    {
        if (cancellationToken.IsCancellationRequested)
        {
            return null;
        }

        var response = await _api.Get(id, ApiKey, cancellationToken);

        return !response.IsSuccessStatusCode ? null : response.Content;
    }
}
