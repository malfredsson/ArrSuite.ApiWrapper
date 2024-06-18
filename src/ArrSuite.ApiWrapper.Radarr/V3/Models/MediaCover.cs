namespace ArrSuite.ApiWrapper.Radarr.V3.Models;

public sealed class MediaCover
{
    public string CoverType { get; init; } = string.Empty;
    public string RemoteUrl { get; init; } = string.Empty;
    public string Url { get; init; } = string.Empty;
}
