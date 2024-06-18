using ArrSuite.ApiWrapper.Lidarr.V1.Models;
using Refit;

namespace ArrSuite.ApiWrapper.Lidarr.V1.Apis;

internal interface IAlbumLookupApi
{
    [Get("/album/lookup")]
    Task<IApiResponse<IReadOnlyCollection<Album>?>> TermLookup(
        string term,
        [Header("X-Api-Key")] string apiKey,
        CancellationToken cancellationToken);
}
