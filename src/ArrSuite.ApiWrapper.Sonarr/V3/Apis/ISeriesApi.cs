using ArrSuite.ApiWrapper.Sonarr.V3.Models;
using Refit;

namespace ArrSuite.ApiWrapper.Sonarr.V3.Apis;

internal interface ISeriesApi
{
    [Get("/series")]
    Task<IApiResponse<IReadOnlyCollection<Series>?>> Series(
        [Header("X-Api-Key")] string apiKey,
        CancellationToken cancellationToken);

    [Get("/series/{id}")]
    Task<IApiResponse<Series?>> Series(
        long id,
        [Header("X-Api-Key")] string apiKey,
        CancellationToken cancellationToken);
}
