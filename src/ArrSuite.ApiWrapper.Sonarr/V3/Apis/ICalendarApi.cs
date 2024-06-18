using ArrSuite.ApiWrapper.Sonarr.V3.Models;
using Refit;

namespace ArrSuite.ApiWrapper.Sonarr.V3.Apis;

internal interface ICalendarApi
{
    [Get("/calendar")]
    Task<IApiResponse<IReadOnlyCollection<Episode>?>> Calendar(
        [Query] DateTime? start,
        [Query] DateTime? end,
        [Query] bool unmonitored,
        [Query] bool includeSeries,
        [Query] bool includeEpisodeFile,
        [Query] bool includeEpisodeImages,
        [Header("X-Api-Key")] string apiKey,
        CancellationToken cancellationToken);
}
