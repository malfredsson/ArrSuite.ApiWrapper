using System.Collections.ObjectModel;

namespace ArrSuite.ApiWrapper.Radarr.V3.Models;

public sealed class MovieStatistics
{
    public IReadOnlyCollection<string> ReleaseGroups { get; init; } = new Collection<string>();
    public double SizeOnDisk { get; init; }
    public int MovieFileCount { get; init; }
}
