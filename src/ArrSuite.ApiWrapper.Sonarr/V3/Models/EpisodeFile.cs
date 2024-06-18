using System.Collections.ObjectModel;
using ArrSuite.ApiWrapper.Sonarr.V3.Models.Enums;

namespace ArrSuite.ApiWrapper.Sonarr.V3.Models;

public sealed class EpisodeFile
{
    public int SeriesId { get; set; }
    public int SeasonNumber { get; set; }
    public string RelativePath { get; set; } = string.Empty;
    public string Path { get; set; } = string.Empty;
    public long Size { get; set; }
    public DateTime DateAdded { get; set; }
    public string SceneName { get; set; } = string.Empty;
    public string ReleaseGroup { get; set; } = string.Empty;
    public IReadOnlyCollection<Language> Languages { get; set; } = new Collection<Language>();
    public QualityDetails Quality { get; set; } = new();
    public IReadOnlyCollection<CustomFormat> CustomFormats { get; set; } = new Collection<CustomFormat>();
    public int CustomFormatScore { get; set; }
    public int? IndexerFlags { get; set; }
    public ReleaseType? ReleaseType { get; set; }
    public MediaInfo MediaInfo { get; set; } = new();
    public bool QualityCutoffNotMet { get; set; }
}
