using ArrSuite.ApiWrapper.Lidarr.V1.Models;
using Refit;

namespace ArrSuite.ApiWrapper.Lidarr.V1.Apis;

internal interface IAlbumApi
{
    [Get("/album")]
    Task<IApiResponse<IReadOnlyCollection<Album>?>> Get(
        [Header("X-Api-Key")] string apiKey,
        CancellationToken cancellationToken);

    [Get("/album/{id}")]
    Task<IApiResponse<Album?>> Get(
        long id,
        [Header("X-Api-Key")] string apiKey,
        CancellationToken cancellationToken);
}
