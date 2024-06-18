using ArrSuite.ApiWrapper.Radarr.V3.Models.Enums;

namespace ArrSuite.ApiWrapper.Radarr.V3.Models;

public sealed class AddMovieOptions
{
    public bool IgnoreEpisodesWithFiles { get; init; }
    public bool IgnoreEpisodesWithoutFiles { get; init; }
    public bool SearchForMovie { get; init; }
    public AddMovieMethod AddMethod { get; init; }
    public MonitorTypes Monitor { get; init; }
}
