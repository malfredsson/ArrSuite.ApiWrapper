using ArrSuite.ApiWrapper.Radarr.V3.Models.Enums;

namespace ArrSuite.ApiWrapper.Radarr.V3.Models;

public sealed class MonitoringOptions
{
    public bool IgnoreEpisodesWithFiles { get; init; }
    public bool IgnoreEpisodesWithoutFiles { get; init; }
    public MonitorTypes Monitor { get; set; }
}
