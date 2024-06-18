using ArrSuite.ApiWrapper.Radarr.V3.Models.Enums;

namespace ArrSuite.ApiWrapper.Radarr.V3.Models;

public sealed class MovieTitle
{
    public int Id { get; init; }
    public int MovieMetadataId { get; init; }
    public string CleanTitle { get; init; } = string.Empty;
    public SourceType SourceType { get; init; }
    public string Title { get; init; } = string.Empty;
}
