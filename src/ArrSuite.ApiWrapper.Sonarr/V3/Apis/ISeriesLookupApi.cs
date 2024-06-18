using ArrSuite.ApiWrapper.Sonarr.V3.Models;
using Refit;

namespace ArrSuite.ApiWrapper.Sonarr.V3.Apis;

internal interface ISeriesLookupApi
{
    [Get("/series/lookup")]
    Task<IApiResponse<IReadOnlyCollection<Series>?>> TermLookup(
        string term,
        [Header("X-Api-Key")] string apiKey,
        CancellationToken cancellationToken);
}
