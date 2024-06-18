using ArrSuite.ApiWrapper.Sonarr.V3.Models.Enums;

namespace ArrSuite.ApiWrapper.Sonarr.V3.Models;

public sealed class MediaCover
{
    public MediaCoverTypes CoverType { get; set; }
    public string Url { get; set; } = string.Empty;
    public string RemoteUrl { get; set; } = string.Empty;
}
