using System.Collections.ObjectModel;
using ArrSuite.ApiWrapper.Radarr.V3.Models.Enums;

namespace ArrSuite.ApiWrapper.Radarr.V3.Models;

public sealed class Movie
{
    public AddMovieOptions AddOptions { get; init; } = new();
    public DateTime? Added { get; init; }
    public DateTime? DigitalRelease { get; init; }
    public DateTime? InCinemas { get; init; }
    public DateTime? PhysicalRelease { get; init; }
    public IReadOnlyCollection<MediaCover> Images { get; init; } = new Collection<MediaCover>();
    public IReadOnlyCollection<MovieTitle> AlternateTitles { get; init; } = new Collection<MovieTitle>();
    public HashSet<int> Tags { get; init; } = [];
    public IReadOnlyCollection<string>? Genres { get; init; }
    public Language? OriginalLanguage { get; init; }
    public MovieCollection? Collection { get; init; }
    public MovieFile? MovieFile { get; init; }
    public MovieStatistics? Statistics { get; init; }
    public Ratings? Ratings { get; init; }
    public bool? HasFile { get; init; }
    public bool IsAvailable { get; init; }
    public bool Monitored { get; init; }
    public float Popularity { get; init; }
    public long? SizeOnDisk { get; init; }
    public int Id { get; init; }
    public int MovieFileId { get; init; }
    public int QualityProfileId { get; init; }
    public int Runtime { get; init; }
    public int? SecondaryYear { get; init; }
    public int SecondaryYearSourceId { get; init; }
    public int Year { get; init; }
    public int TmdbId { get; init; }
    public string Certification { get; init; } = string.Empty;
    public string CleanTitle { get; init; } = string.Empty;
    public string Folder { get; init; } = string.Empty;
    public string FolderName { get; init; } = string.Empty;
    public string ImdbId { get; init; } = string.Empty;
    public MovieStatusType MinimumAvailability { get; init; }
    public string OriginalTitle { get; init; } = string.Empty;
    public string Overview { get; init; } = string.Empty;
    public string Path { get; init; } = string.Empty;
    public string PhysicalReleaseNote { get; init; } = string.Empty;
    public string RemotePoster { get; init; } = string.Empty;
    public string RootFolderPath { get; init; } = string.Empty;
    public string SortTitle { get; init; } = string.Empty;
    public string Status { get; init; } = string.Empty;
    public string Studio { get; init; } = string.Empty;
    public string Title { get; init; } = string.Empty;
    public string TitleSlug { get; init; } = string.Empty;
    public string Website { get; init; } = string.Empty;
    public string YouTubeTrailerId { get; init; } = string.Empty;
}
