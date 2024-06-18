using System.Collections.ObjectModel;

namespace ArrSuite.ApiWrapper.Sonarr.V3.Models;

public sealed class Episode
{
    public int SeriesId { get; set; }
    public int TvdbId { get; set; }
    public int EpisodeFileId { get; set; }
    public int SeasonNumber { get; set; }
    public int EpisodeNumber { get; set; }
    public string Title { get; set; } = string.Empty;
    public string AirDate { get; set; } = string.Empty;
    public DateTime? AirDateUtc { get; set; }
    public int Runtime { get; set; }
    public string FinaleType { get; set; } = string.Empty;
    public string Overview { get; set; } = string.Empty;
    public EpisodeFile EpisodeFile { get; set; } = new();
    public bool HasFile { get; set; }
    public bool Monitored { get; set; }
    public int? AbsoluteEpisodeNumber { get; set; }
    public int? SceneAbsoluteEpisodeNumber { get; set; }
    public int? SceneEpisodeNumber { get; set; }
    public int? SceneSeasonNumber { get; set; }
    public bool UnverifiedSceneNumbering { get; set; }
    public DateTime? EndTime { get; set; }
    public DateTime? GrabDate { get; set; }
    public string SeriesTitle { get; set; } = string.Empty;
    public Series Series { get; set; } = new();
    public IReadOnlyCollection<MediaCover> Images { get; set; } = new Collection<MediaCover>();
}
