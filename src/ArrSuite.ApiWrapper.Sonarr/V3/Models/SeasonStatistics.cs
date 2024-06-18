using System.Collections.ObjectModel;

namespace ArrSuite.ApiWrapper.Sonarr.V3.Models;

public sealed class SeasonStatistics
{
    public DateTime? NextAiring { get; set; }
    public DateTime? PreviousAiring { get; set; }
    public int EpisodeFileCount { get; set; }
    public int EpisodeCount { get; set; }
    public int TotalEpisodeCount { get; set; }
    public long SizeOnDisk { get; set; }
    public IReadOnlyCollection<string> ReleaseGroups { get; set; } = new Collection<string>();
}
