using System.Collections.ObjectModel;

namespace ArrSuite.ApiWrapper.Radarr.V3.Models;

public sealed class MovieFile
{
    public DateTime? DateAdded { get; init; }
    public IReadOnlyCollection<CustomFormat> CustomFormats { get; init; } = new Collection<CustomFormat>();
    public IReadOnlyCollection<Language> Languages { get; init; } = new Collection<Language>();
    public MediaInfo? MediaInfo { get; init; }
    public QualityDetails? Quality { get; init; }
    public bool QualityCutoffNotMet { get; init; }
    public double Size { get; init; }
    public int CustomFormatScore { get; init; }
    public int Id { get; init; }
    public int? IndexerFlags { get; init; }
    public long MovieId { get; init; }
    public string Edition { get; init; } = string.Empty;
    public string OriginalFilePath { get; init; } = string.Empty;
    public string Path { get; init; } = string.Empty;
    public string RelativePath { get; init; } = string.Empty;
    public string ReleaseGroup { get; init; } = string.Empty;
    public string SceneName { get; init; } = string.Empty;
}
