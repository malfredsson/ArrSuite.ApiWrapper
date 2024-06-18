using System.Collections.ObjectModel;
using ArrSuite.ApiWrapper.Sonarr.V3.Models.Enums;

namespace ArrSuite.ApiWrapper.Sonarr.V3.Models;

public sealed class Series
{
    public string Title { get; set; } = string.Empty;
    public IReadOnlyCollection<AlternateTitle> AlternateTitles { get; set; } =
        new Collection<AlternateTitle>();
    public string SortTitle { get; set; } = string.Empty;
    public SeriesStatusType Status { get; set; }
    public bool Ended => Status == SeriesStatusType.Ended;
    public string ProfileName { get; set; } = string.Empty;
    public string Overview { get; set; } = string.Empty;
    public DateTime? NextAiring { get; set; }
    public DateTime? PreviousAiring { get; set; }
    public string Network { get; set; } = string.Empty;
    public string AirTime { get; set; } = string.Empty;
    public IReadOnlyCollection<MediaCover> Images { get; set; } = new Collection<MediaCover>();
    public Language OriginalLanguage { get; set; } = new();
    public string RemotePoster { get; set; } = string.Empty;
    public IReadOnlyCollection<Season> Seasons { get; set; } = new Collection<Season>();
    public int Year { get; set; }
    public string Path { get; set; } = string.Empty;
    public int QualityProfileId { get; set; }
    public bool SeasonFolder { get; set; }
    public bool Monitored { get; set; }
    public NewItemMonitorTypes MonitorNewItems { get; set; }
    public bool UseSceneNumbering { get; set; }
    public int Runtime { get; set; }
    public int TvdbId { get; set; }
    public int TvRageId { get; set; }
    public int TvMazeId { get; set; }
    public DateTime? FirstAired { get; set; }
    public DateTime? LastAired { get; set; }
    public SeriesTypes SeriesType { get; set; }
    public string CleanTitle { get; set; } = string.Empty;
    public string ImdbId { get; set; } = string.Empty;
    public string TitleSlug { get; set; } = string.Empty;
    public string RootFolderPath { get; set; } = string.Empty;
    public string Folder { get; set; } = string.Empty;
    public string Certification { get; set; } = string.Empty;
    public IReadOnlyCollection<string> Genres { get; set; } = new Collection<string>();
    public HashSet<int> Tags { get; set; } = [];
    public DateTime Added { get; set; }
    public AddSeriesOptions AddOptions { get; set; } = new();
    public Ratings Ratings { get; set; } = new();
    public SeriesStatistics Statistics { get; set; } = new();
    public bool? EpisodesChanged { get; set; }
}
