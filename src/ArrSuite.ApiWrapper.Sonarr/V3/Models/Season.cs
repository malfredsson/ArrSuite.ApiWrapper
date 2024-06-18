using System.Collections.ObjectModel;

namespace ArrSuite.ApiWrapper.Sonarr.V3.Models;

public sealed class Season
{
    public int SeasonNumber { get; set; }
    public bool Monitored { get; set; }
    public SeasonStatistics Statistics { get; set; } = new();
    public IReadOnlyCollection<MediaCover> Images { get; set; } = new Collection<MediaCover>();
}
