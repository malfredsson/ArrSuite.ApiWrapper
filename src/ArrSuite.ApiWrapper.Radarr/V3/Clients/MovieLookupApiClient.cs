using ArrSuite.ApiWrapper.Radarr.V3.Apis;
using ArrSuite.ApiWrapper.Radarr.V3.Models;
using ArrSuite.ApiWrapper.V3;
using Refit;

namespace ArrSuite.ApiWrapper.Radarr.V3.Clients;

public class MovieLookupApiClient : ArrSuiteV3ApiClient
{
    private readonly IMovieLookupApi _api;
    
    internal MovieLookupApiClient(string url, string apiKey) : base(url, apiKey)
    {
        _api = RestService.For<IMovieLookupApi>(Url);
    }
    
    /// <summary>
    /// Lookup movies using a search term
    /// </summary>
    /// <param name="term">The search term</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Found movies matching the search term supplied</returns>
    public async Task<IReadOnlyCollection<Movie>?> TermLookup(string term, CancellationToken cancellationToken = default)
    {
        if (cancellationToken.IsCancellationRequested)
        {
            return null;
        }

        var result = await _api.TermLookup(term, ApiKey, cancellationToken);

        return !result.IsSuccessStatusCode ? null : result.Content;
    }

    /// <summary>
    /// Gets details about a single movie using an IMDB (Internet Movie Database) id
    /// </summary>
    /// <param name="imdbId">The IMDB id</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Found movie matching the supplied IMDB id</returns>
    public async Task<ExternalLookupResult?> ImdbLookup(string imdbId, CancellationToken cancellationToken = default)
    {
        if (cancellationToken.IsCancellationRequested)
        {
            return null;
        }

        var response = await _api.ImdbLookup(imdbId, ApiKey, cancellationToken);

        return !response.IsSuccessStatusCode ? null : response.Content;
    }

    /// <summary>
    /// Gets details about a single movie using an TMDB (The Movie Database) id
    /// </summary>
    /// <param name="tmdbId">The TMDB id</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Found movie matching the supplied TMDB id</returns>
    public async Task<ExternalLookupResult?> TmdbLookup(string tmdbId, CancellationToken cancellationToken = default)
    {
        if (cancellationToken.IsCancellationRequested)
        {
            return null;
        }

        var response = await _api.TmdbLookup(tmdbId, ApiKey, cancellationToken);

        return !response.IsSuccessStatusCode ? null : response.Content;
    }
}
