using ArrSuite.ApiWrapper.Sonarr.V3.Models.Enums;

namespace ArrSuite.ApiWrapper.Sonarr.V3.Models;

public sealed class AddSeriesOptions
{
    public bool SearchForMissingEpisodes { get; set; }
    public bool SearchForCutoffUnmetEpisodes { get; set; }
    public bool IgnoreEpisodesWithFiles { get; set; }
    public bool IgnoreEpisodesWithoutFiles { get; set; }
    public MonitorTypes Monitor { get; set; }
}
