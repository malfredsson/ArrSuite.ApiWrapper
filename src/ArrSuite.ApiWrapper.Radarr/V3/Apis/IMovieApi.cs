using ArrSuite.ApiWrapper.Radarr.V3.Models;
using Refit;

namespace ArrSuite.ApiWrapper.Radarr.V3.Apis;

internal interface IMovieApi
{
    [Get("/movie")]
    Task<IApiResponse<IReadOnlyCollection<Movie>?>> Get(
        [Header("X-Api-Key")] string apiKey,
        CancellationToken cancellationToken);

    [Get("/movie/{id}")]
    Task<IApiResponse<Movie?>> Get(
        long id,
        [Header("X-Api-Key")] string apiKey,
        CancellationToken cancellationToken);
}
