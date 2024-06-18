using ArrSuite.ApiWrapper.Radarr.V3.Models;
using Refit;

namespace ArrSuite.ApiWrapper.Radarr.V3.Apis;

internal interface IMovieLookupApi
{
    [Get("/movie/lookup")]
    Task<IApiResponse<IReadOnlyCollection<Movie>?>> TermLookup(
        string term,
        [Header("X-Api-Key")] string apiKey,
        CancellationToken cancellationToken);

    [Get("/movie/lookup/imdb")]
    Task<IApiResponse<ExternalLookupResult?>> ImdbLookup(
        string imdbId,
        [Header("X-Api-Key")] string apiKey,
        CancellationToken cancellationToken);

    [Get("/movie/lookup/tmdb")]
    Task<IApiResponse<ExternalLookupResult?>> TmdbLookup(
        string tmdbId,
        [Header("X-Api-Key")] string apiKey,
        CancellationToken cancellationToken);
}
