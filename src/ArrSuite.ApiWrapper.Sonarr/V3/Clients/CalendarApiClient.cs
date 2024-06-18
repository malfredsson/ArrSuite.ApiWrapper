using ArrSuite.ApiWrapper.Sonarr.V3.Apis;
using ArrSuite.ApiWrapper.Sonarr.V3.Models;
using ArrSuite.ApiWrapper.V3;
using Refit;

namespace ArrSuite.ApiWrapper.Sonarr.V3.Clients;

public sealed class CalendarApiClient : ArrSuiteV3ApiClient
{
    private readonly ICalendarApi _api;

    internal CalendarApiClient(string url, string apiKey) : base(url, apiKey)
    {
        _api = RestService.For<ICalendarApi>(Url);
    }

    /// <summary>
    /// Gets all episodes from the calendar
    /// </summary>
    /// <param name="start">The start date for a limited span</param>
    /// <param name="end">The end date for a limited span</param>
    /// <param name="unmonitored">Only show unmonitored episodes</param>
    /// <param name="includeSeries">Includes details about the series that the episode belongs to</param>
    /// <param name="includeEpisodeFile">Includes details about the file (if any) that belongs to an episode</param>
    /// <param name="includeEpisodeImages">Includes images from the episode in the result</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A collection of episodes within the supplied <paramref name="start"/> and <paramref name="end"/></returns>
    public async Task<IReadOnlyCollection<Episode>?> Get(DateTime? start = null, DateTime? end = null,
        bool unmonitored = false, bool includeSeries = false, bool includeEpisodeFile = false,
        bool includeEpisodeImages = false, CancellationToken cancellationToken = default)
    {
        if (cancellationToken.IsCancellationRequested)
        {
            return null;
        }

        var response = await _api.Calendar(start, end, unmonitored, includeSeries, includeEpisodeFile,
            includeEpisodeImages, ApiKey, cancellationToken);

        return !response.IsSuccessStatusCode ? null : response.Content;
    }
}
